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
            #region SERVICE LOCATOR SINGLETONE

            FileLogger fileLogger = FileLogger.Instanse;
            SingletonServiceLocator.Instance().Add<FileLogger>(fileLogger);
            FileLogger returnedFileLog = SingletonServiceLocator.Instance().Get<FileLogger>();
            SingletonServiceLocator.Instance().Remove<FileLogger>();
            #endregion

            StaticServiceLocator.Registrate<ILogger>(ConsoleLogger.Instanse);

            IvanLib ivan = new IvanLib();

            Console.WriteLine("Hello World! " + ivan.GetData());
            ILogger log = StaticServiceLocator.GetService<ILogger>();
            log.Debug("It`s debug!");
            log.Error("It`s error!");
            log.Info("It`s info!");

            #region Toy Clone Functionality
            Toy toy1 = new Toy("Bear", 2.23f, CategoryType.TOYS, 3, "Very funny toy Very funny toy", DateTime.Now, new Manufacturer() { Name = "Lego" , LicenseNumber = 132451, Address="USA, Washington, JastStreet, 42"});
            Toy toy2 = toy1.Clone() as Toy;
            toy2.SetName("BadToy");
            toy2.SetPrice(123);
            toy1.ManufacturerData = new Manufacturer() { Name = "SharashkaProduction", LicenseNumber = 546154615, Address = "China, unknown" };

            log.Info("\n\n\n" + toy1.ToString() + "\n\n\n" + toy2.ToString() + "\n\n\n");
            #endregion

            #region Phone Clone Functionality
            Phone SamsungS7 = new Phone("S7", 16999, CategoryType.PHONES, PhoneType.SMARTPHONES, "Samsung",
                                        new DateTime(2016, 2, 21), 5.1f, OSType.ANDROID_6_0, 2, 4, 32, 12, 3000,
                                        new Communication(BluetoothSpecification.Bluetooth_4_2, true, true, true, true));
            Console.WriteLine("СамсунгS7 оригинал:\n");
            Console.WriteLine(SamsungS7);

            Phone ChinaCopySaNsungS7 = (Phone)SamsungS7.Clone();
            ChinaCopySaNsungS7.Comm.WiFi = false;
            ChinaCopySaNsungS7.Comm.GPS = false;
            ChinaCopySaNsungS7.Comm.AGPS = false;
            ChinaCopySaNsungS7.Comm.OTG = false;
            ChinaCopySaNsungS7.BrandName = "SaNsung";

            Console.WriteLine("\nСамсунгS7 китайская подделка:\n");
            Console.WriteLine(ChinaCopySaNsungS7);
            Console.WriteLine("\nСамсунгS7 оригинал после изменения клона:\n");
            Console.WriteLine(SamsungS7);
            #endregion

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
