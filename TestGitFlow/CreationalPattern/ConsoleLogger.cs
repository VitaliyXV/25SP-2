using System;


namespace CreationalPattern
{
    public class ConsoleLogger : ILogger
    {
        private static ConsoleLogger instance;
        private ConsoleLogger()
        {
            
        }

        public static ConsoleLogger Instanse
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }
                return instance = new ConsoleLogger();
            }
        }
       
        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(DateTime.Now + "; " + "Info: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Debug(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(DateTime.Now + "; " + "Debug: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(DateTime.Now + "; " + "Warning: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DateTime.Now + "; " + "Error: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Fail(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now + "; " + "Fail: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
