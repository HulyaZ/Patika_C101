using System;

namespace Patika_C101_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger(); 
            databaseLogger.writeLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.writeLog();
        }

    }


}