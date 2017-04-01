using System;


namespace CreationalPattern
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(DateTime.Now + "; " + "Info: " + message);
        }
        public void Debug(string message)
        {
            Console.WriteLine(DateTime.Now + "; " + "Debug: " + message);
        }
        public void Warning(string message)
        {
            Console.WriteLine(DateTime.Now + "; " + "Warning: " + message);
        }
        public void Error(string message)
        {
            Console.WriteLine(DateTime.Now + "; " + "Error: " + message);
        }
        public void Fail(string message)
        {
            Console.WriteLine(DateTime.Now + "; " + "Fail: " + message);
        }
    }
}
