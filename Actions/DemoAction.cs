using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Tech.Aerove.StreamDeck.Client.Actions;

namespace HD2StrategemStreamDeckPlugin.Actions
{
    [PluginAction("com.keithcassidy.hd2stratagem.demoaction")]
    public class DemoAction : ActionBase
    {
        private readonly ILogger<DemoAction> _logger;

        public DemoAction(ILogger<DemoAction> logger)
        {
            _logger = logger;
        }

        public override async Task WillAppearAsync()
        {
            var col = Context.Column;
            var row = Context.Row;
            _logger.LogInformation("My cordinates are Col:{col} Row:{row}", col, row);
            await Dispatcher.ShowOkAsync();
        }

        public override Task ApplicationDidLaunchAsync(string application)
        {
            return Task.CompletedTask;
        }

        public override void KeyUp(int userDesiredState)
        {
            Dispatcher.ShowOk();
        }

        public override void KeyDown(int userDesiredState)
        {
            Dispatcher.ShowOk();
        }
    }
}