using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public class PhoneSettings : IItemSettings
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public CategoryType Category { get; set; }
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


        public PhoneSettings()
        {
        }

        public PhoneSettings(string name, float price, CategoryType category, PhoneType type,
                     string brandName, DateTime releaseDate, float displaySize, OSType OS, int simCardQuantity,
                     float RAM, float ROM, float camera, int batteryCapacity, Communication comm)
        {
            Name = name;
            Price = price;
            Category = category;
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

    }
}
