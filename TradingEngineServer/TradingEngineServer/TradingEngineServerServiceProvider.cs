using System;
using System.Collections.Generic;
using System.Text;


//public static class means it is called at the beginning of the program
namespace TradingEngineServer.Core
{
    public static class TradingEngineServerServiceProvider
    {
        public static IServiceProvider ServiceProvider { get; set; }
    }
}
