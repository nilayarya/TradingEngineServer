using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddOptions();
                services.Configure<TradingEngineServerConfiguration>(context.Configuration.GetSection(nameof(TradingEngineServerConfiguration)));

                services.AddSingleton<ITradingEngineServer,TradingEngineServer>(); 
                //a singleton class is a class that can have only one object (an instance of the class) at a time.
                //it will make sure any instance of our ITradingEngineServer is associated with TradingEngineServer
                //the hosted server will have only one implementation of TradingEngineServer
                services.AddHostedService<TradingEngineServer>();
            }).Build();
    }
}
