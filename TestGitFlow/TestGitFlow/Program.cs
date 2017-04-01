using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using CreationalPattern;
using System.Configuration;
using TestGitFlow.Model;

namespace TestGitFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticServiceLocator.Registrate<ILogger>(ConsoleLogger.Instanse);

            IvanLib ivan = new IvanLib();

            Console.WriteLine("Hello World! " + ivan.GetData());
            ILogger log = StaticServiceLocator.GetService<ILogger>();
            log.Debug("It`s debug!");
            log.Error("It`s error!");
            log.Info("It`s info!");

            Toy toy1 = new Toy("Bear", 2.23f, CategoryType.TOYS, 3, "Very funny toy Very funny toy", DateTime.Now, new Manufacturer() { Name = "Lego" , LicenseNumber = 132451, Address="USA, Washington, JastStreet, 42"});
            var toy2 = toy1.Clone();
            ((Toy)toy2).SetName("BadToy");
            Console.WriteLine(toy1.ToString() + "\n\n\n" + toy2.ToString());

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
