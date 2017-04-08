using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public class Toy : Item
    {
        public int MinAge { get; set; }
        public string Description { get; set; }
        public DateTime ProduceDate { get; set; }
        public Manufacturer ManufacturerData { get; set; }
        public Toy()
        {
            ManufacturerData = new Manufacturer();
        }

        public Toy(string name, float price, CategoryType category, int minAge, string description, DateTime produceDate, Manufacturer manufacturer)
            : base(name, price, category)
        {
            Name = name;
            Price = price;
            Category = category;
            MinAge = minAge;
            Description = description;
            ProduceDate = produceDate;
            ManufacturerData = manufacturer;
        }

        public void SetName(string name)
        { 
           Name = name;
        }

        public void SetPrice(float price)
        {
            Price = price;
        }
        public override Item Clone()
        {
            return new Toy(Name, Price, Category, MinAge, Description, ProduceDate, new Manufacturer() { Name = ManufacturerData.Name, LicenseNumber = ManufacturerData.LicenseNumber, Address = ManufacturerData.Address });
        }

        public override string ToString()
        {
            return "Toy Name: " + Name + " Price: " + Price + "$ Category: " + Category + "\nMinAge: " + MinAge + "\nDescription: " + Description + " ProduceDate: " + ProduceDate + "\n----------- Manufacturer Data ---------\n" + "Manufacturer Name: " + ManufacturerData.Name + " LicenseNumber " + ManufacturerData.LicenseNumber + "\nAddress: " + ManufacturerData.Address;
        }
    }
}
