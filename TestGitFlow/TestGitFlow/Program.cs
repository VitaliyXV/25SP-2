using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using CreationalPattern;
using System.Configuration;


namespace TestGitFlow
{
    class Program
    {
        static void Main(string[] args)
        {

            IvanLib ivan = new IvanLib();

            Console.WriteLine("Hello World! " + ivan.GetData());
            ILogger log = new ConsoleLogger();
            log.Debug("It`s debug!");
            log.Error("It`s error!");
            log.Info("It`s info!");

        }

        private string GetLogFile()
        {
            try
            {
                AppSettingsReader reader = new AppSettingsReader();
                return reader.GetValue("LogFile", typeof(string)).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return "default.log";
            }

        }
    }
}
