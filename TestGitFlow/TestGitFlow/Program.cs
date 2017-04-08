﻿using System;
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

            //FileLogger fileLogger = FileLogger.Instanse;
            //SingletonServiceLocator.Instance().Add<FileLogger>(fileLogger);
            //FileLogger returnedFileLog = SingletonServiceLocator.Instance().Get<FileLogger>();
            //SingletonServiceLocator.Instance().Remove<FileLogger>();
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

            #region Game Clone Functionality
            Game game1 = new Game("Dark Souls III", 1, "FromSoftware, Inc", new DateTime(2016, 04, 11), GamesGenre.Action, SupportedPlatforms.PC, LicenseType.Shareware, DistributeType.OpticalDrive, 49.99f, 25f);
            Console.WriteLine("\nGame Clone Functionality");
            Console.WriteLine("First Game Object: ");
            Console.WriteLine(game1);
                        
            Game game2 = game1.Clone() as Game;
            Console.WriteLine("\nClonned Game Object: ");
            Console.WriteLine(game2);
                        
            game2.setName("Dark Souls III - The Ringed City");
            game2.setId(2);
            game2.setDistribution(DistributeType.Steam);
            game2.setPrice(9.99f);
            Console.WriteLine("\nClonned Changed Game Object: ");
            Console.WriteLine(game2);
            #endregion



            #region Diary Clone Functionality
            CategoryType category = CategoryType.FOODS;
            DateTime dateOfMade = new DateTime(2017, 4, 7);
            DateTime dateOfTermEnd = new DateTime(2017, 4, 11);
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.Name = "Milk King";
            manufacturer.LicenseNumber = 22222323;
            manufacturer.Address = "Plane Earth";
            string name = "Milk";
            float price = 10.2f;

            Dairy originDairy = new Dairy(name, price, category, dateOfMade, dateOfTermEnd, manufacturer);
            Dairy cloneDairy = (Dairy)originDairy.Clone();

            Console.WriteLine("===============");
            Console.WriteLine("\nOringinal dairy ");
            Console.WriteLine(originDairy);



           
           
           
            Manufacturer cloneManufacturer = cloneDairy.GetManufacturer();
            cloneManufacturer.Name = "Milk Dark Lord!!";
            cloneManufacturer.LicenseNumber = 122345545;
            price = 12f;
            dateOfMade = new DateTime(2017, 4, 6);
            cloneDairy.SetDateOfMade(dateOfMade);
            cloneDairy.SetPrice(price);
            cloneDairy.SetManufacturer(cloneManufacturer);

            Console.WriteLine("\nClone dairy ");
            Console.WriteLine(cloneDairy);
            log.Warning("Is origin dairy and clone dairy is equel ?? " + object.Equals(cloneDairy, originDairy));

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
