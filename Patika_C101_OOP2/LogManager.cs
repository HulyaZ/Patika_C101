using System;


namespace Patika_C101_OOP2
{
    public class LogManager:ILogger
    {
        public ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;   
        }

        public void writeLog()
        {
            _logger.writeLog();
        }
    }
}
