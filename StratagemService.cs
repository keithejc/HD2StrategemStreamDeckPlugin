using Microsoft.AspNetCore.Components;
using Tech.Aerove.StreamDeck.Client;
using Tech.Aerove.StreamDeck.Client.Events;
using Interceptor;
using System.Diagnostics;
using HD2StrategemStreamDeckPlugin;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Concurrent;

namespace HD2StrategemStreamDeckPlugin
{
    public class StratagemService : BackgroundService
    {
        private readonly ILogger<StratagemService> _logger;
        private readonly EventManager _eventsManager;
        private readonly IElgatoDispatcher _elgatoDispatcher;

        private Input input;

        private Dictionary<string, CancellationTokenSource> actionThreads;
        private object lockActionThreads = new object();
        private object lockDictionary = new object();

        public StratagemService(ILogger<StratagemService> logger, EventManager eventsManager, IElgatoDispatcher dispatcher)
        {
            _logger = logger;
            _eventsManager = eventsManager;
            _elgatoDispatcher = dispatcher;

            actionThreads = new Dictionary<string, CancellationTokenSource>();

            //eventsManager.OnKeyUp += HandleKeyUp;
            eventsManager.OnKeyDown += HandleKeyDown;
            eventsManager.OnDidReceiveSettings += DidReceiveSettings;
            eventsManager.OnDidReceiveGlobalSettings += DidReceiveGlobalSettings;

            eventsManager.OnWillAppear += OnWillAppear;

            input = new Input();
            input.KeyboardFilterMode = KeyboardFilterMode.All;
            input.Load();

            //input.OnKeyPressed += Input_OnKeyPressed;
        }

        //destructor
        ~StratagemService()
        {
            //            _eventsManager.OnKeyUp -= HandleKeyUp;
            _eventsManager.OnKeyDown -= HandleKeyDown;
            _eventsManager.OnDidReceiveSettings -= DidReceiveSettings;
            _eventsManager.OnDidReceiveGlobalSettings -= DidReceiveGlobalSettings;
            input.Unload();
        }

        private void ActionThreadFunction(KeyDownEvent e, CancellationToken cancelToken)
        {
            var stratagemId = (StratagemId)e.Payload.Settings["stratagemId"].Value<int>();

            lock (lockActionThreads)
            {
                string buttons = Stratagem.GetStratagemButtons(stratagemId);

                input.SendKey(Keys.Home, KeyState.Down | KeyState.E0);
                Thread.Sleep(1);
                input.SendKey(Keys.Home, KeyState.Up | KeyState.E0);
                Thread.Sleep(1);

                foreach (var item in buttons)
                {
                    if (item == 'u')
                    {
                        input.SendKey(Keys.Up, KeyState.Down | KeyState.E0);
                        Thread.Sleep(1);
                        input.SendKey(Keys.Up, KeyState.Up | KeyState.E0);
                    }
                    else if (item == 'd')
                    {
                        input.SendKey(Keys.Down, KeyState.Down | KeyState.E0);
                        Thread.Sleep(1);
                        input.SendKey(Keys.Down, KeyState.Up | KeyState.E0);
                    }
                    else if (item == 'l')
                    {
                        input.SendKey(Keys.Left, KeyState.Down | KeyState.E0);
                        Thread.Sleep(1);
                        input.SendKey(Keys.Left, KeyState.Up | KeyState.E0);
                    }
                    else if (item == 'r')
                    {
                        input.SendKey(Keys.Right, KeyState.Down | KeyState.E0);
                        Thread.Sleep(1);
                        input.SendKey(Keys.Right, KeyState.Up | KeyState.E0);
                    }
                    Thread.Sleep(1);
                }
            }

            if (e.Payload.Settings.ContainsKey("cooldown") && e.Payload.Settings["cooldown"] != null && e.Payload.Settings["cooldown"].ToString() != "")
            {
                var cooldown = (int)e.Payload.Settings["cooldown"].Value<int>();

                if (cooldown > 0 && cooldown < 700)
                {
                    for (global::System.Int32 i = 0; i < cooldown; i++)
                    {
                        lock (lockActionThreads)
                        {
                            _elgatoDispatcher.SetTitle(e.Context, (cooldown - i).ToString());
                        }
                        if (cancelToken.IsCancellationRequested)
                        {
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                }

                //return to normal
                lock (lockDictionary)
                {
                    ApplySettings(e.Context, e.Payload.Settings);
                }
                // var bitmap = new Bitmap("icons/" + Stratagem.GetIconImage(stratagemId));
            }

            //remove the thread from the dictionary
            lock (lockDictionary)
            {
                if (actionThreads.ContainsKey(e.Context))
                {
                    actionThreads.Remove(e.Context);
                }
            }
        }

        private void HandleKeyDown(object? sender, KeyDownEvent e)
        {
            if (e.Payload.Settings.ContainsKey("stratagemId") && e.Payload.Settings.ContainsKey("stratagemId") != null)
            {
                lock (lockActionThreads)
                {
                    //is there already a thread running for this action?
                    //cancel it if so
                    if (actionThreads.ContainsKey(e.Context))
                    {
                        actionThreads[e.Context].Cancel();
                        return;
                    }
                    else
                    {
                        //create a new thread for this action
                        var cancel = new CancellationTokenSource();
                        var actionThread = new Thread(() => ActionThreadFunction(e, cancel.Token));
                        actionThread.Name = e.Context;
                        actionThreads.Add(e.Context, cancel);
                        actionThread.Start();
                    }
                }
            }
        }

        //we could intercept keypresses and change them to something else by
        //setting e.Handled = true and setting e.key and e.state
        private void Input_OnKeyPressed(object? sender, KeyPressedEventArgs e)
        {
            Debug.WriteLine("key: " + e.Key + " state: " + e.State);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000);
            }
        }

        private void ApplySettings(string context, JObject settings)
        {
            if (settings.ContainsKey("stratagemId") && settings["stratagemId"] != null)
            {
                var stratagemId = (StratagemId)settings["stratagemId"].Value<int>();

                _logger.LogInformation("stratagemId {event}", stratagemId);

                if (settings.ContainsKey("showTitle") && settings["showTitle"] != null && (bool)settings["showTitle"])
                {
                    _elgatoDispatcher.SetTitle(context, Stratagem.GetStratagemTitle(stratagemId));
                }
                else
                {
                    _elgatoDispatcher.SetTitle(context, "");
                }
                string image = "icons/" + Stratagem.GetIconImage(stratagemId);

                _logger.LogInformation("image path {event}", image);

                _elgatoDispatcher.SetImage(context, image);
            }
            else
            {
                _elgatoDispatcher.SetTitle(context, "");
            }
        }

        private void OnWillAppear(object? sender, WillAppearEvent e)
        {
            //get correct stratagem and show icon
            _logger.LogInformation("OnWillAppear settings {event}", e.Payload.Settings);

            ApplySettings(e.Context, e.Payload.Settings);
        }

        public void DidReceiveSettings(object? sender, DidReceiveSettingsEvent e)
        {
            _logger.LogInformation("DidReceiveSettings {event}", e.Payload.Settings.ToString());
            // _elgatoDispatcher.ShowOk(e.Context);

            ApplySettings(e.Context, e.Payload.Settings);
        }

        public void DidReceiveGlobalSettings(object? sender, DidReceiveGlobalSettingsEvent e)
        {
            _logger.LogInformation("StratagemService Received event {event}", e.Event);
        }
    }
}