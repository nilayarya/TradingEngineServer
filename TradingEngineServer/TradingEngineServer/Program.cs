using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using TradingEngineServer.Core;

using var engine = TradingEngineServerHostBuilder.BuildTradingEngineServer();

//builds entire dependency injection container and hosted service in one line
//'using' prefix is used because we want to dispose of the engine once the program terminates
//it gets rid of unmanaged resources like database connections

TradingEngineServerServiceProvider.ServiceProvider = engine.Services;
{
    using var scope = TradingEngineServerServiceProvider.ServiceProvider.CreateScope();
    await engine.RunAsync().ConfigureAwait(false);
}