using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public class Phone : Item
    {
        public PhoneType Type { get; set; }
        public string BrandName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float DisplaySize { get; set; }
        public OSType OS { get; set; }
        public int SimCardQuantity { get; set; }
        public float RAM { get; set; }
        public float ROM { get; set; }
        public float Camera { get; set; }
        public int BatteryCapacity { get; set; }
        public Communication Comm { get; set; }

        public Phone(string name, float price, CategoryType category, PhoneType type,
                     string brandName, DateTime releaseDate, float displaySize, OSType OS, int simCardQuantity,
                     float RAM, float ROM, float camera, int batteryCapacity, Communication comm) :
                    base(name, price, category)
        {
            Type = type;
            BrandName = brandName;
            ReleaseDate = releaseDate;
            DisplaySize = displaySize;
            this.OS = OS;
            SimCardQuantity = simCardQuantity;
            this.RAM = RAM;
            this.ROM = ROM;
            Camera = camera;
            BatteryCapacity = batteryCapacity;
            Comm = comm;
        }

        public override Item Clone()
        {
            return new Phone(Name, Price, Category, Type, BrandName, ReleaseDate, DisplaySize, OS,
                             SimCardQuantity, RAM, ROM, Camera, BatteryCapacity, new Communication(
                             Comm.Bluetooth, Comm.WiFi, Comm.GPS, Comm.AGPS, Comm.OTG));
        }

        public override string ToString()
        {
            return string.Format("Модель: {0}{1};\nЦена: {2}UAH;\nДата выпуска: {3};\nДиагональ дисплея: {4};\nОперационная система: {5};\nКоличество sim-карт: {6}шт;\nОперативная память: {7}Gb;\nВстроенная память: {8}Gb;\nКамера: {9}Mp;\nБатарея: {10}Mah;\nБлютуз: {11};\nWiFi: {12};\nGPS: {13};\nA-GPS: {14};\nOTG: {15}",
                BrandName, Name, Price, ReleaseDate.ToShortDateString(), DisplaySize, OS, SimCardQuantity, RAM, ROM, Camera, BatteryCapacity, Comm.Bluetooth, Comm.WiFi, Comm.GPS, Comm.AGPS, Comm.OTG);
        }

    }
}
