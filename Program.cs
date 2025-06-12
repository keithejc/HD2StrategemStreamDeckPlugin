using HD2StrategemStreamDeckPlugin;
using Serilog;
using Tech.Aerove.StreamDeck.Client;

SerilogConfig.Configure();
IHost host = Host.CreateDefaultBuilder(args)
    .UseSerilog()
    .ConfigureServices((context, services) =>
    {
        services.AddAeroveStreamDeckClient(context);
        services.AddHostedService<StratagemService>();
    })
    .Build();

await host.RunAsync();
