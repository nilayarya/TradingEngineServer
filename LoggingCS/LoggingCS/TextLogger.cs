using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Logging.LoggingConfiguration;

namespace TradingEngineServer.Logging
{
    public class TextLogger : AbstractLogger, ITextLogger
    {
        public TextLogger() :base(IOptions<LoggerConfiguration>) { }
        protected override void Log(LogLevel logLevel, string module, string message)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
