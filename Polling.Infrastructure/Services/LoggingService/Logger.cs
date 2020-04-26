using System;
using Serilog;

namespace Polling.Infrastructure.LoggingService
{
    public class Logger
    {
        public Logger(string errormsg)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            log.Information(errormsg);
        }
    }
}
