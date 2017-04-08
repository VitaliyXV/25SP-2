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

        public Toy(IItemSettings settings)
        {
            var toySettings = settings as ToySettings;
            Name = toySettings.Name;
            Price = toySettings.Price;
            Category = toySettings.Category;
            MinAge = toySettings.MinAge;
            Description = toySettings.Description;
            ProduceDate = toySettings.ProduceDate;
            ManufacturerData = toySettings.ManufacturerData;
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
            return new Toy(new ToySettings(){
                Name = this.Name,
                Price = this.Price,
                Category = this.Category,
                MinAge = this.MinAge,
                Description = this.Description,
                ProduceDate = this.ProduceDate,
                ManufacturerData = new Manufacturer() { Name = ManufacturerData.Name, LicenseNumber = ManufacturerData.LicenseNumber, Address = ManufacturerData.Address }
            });
        }

        public override string ToString()
        {
            return "Toy Name: " + Name + " Price: " + Price + "$ Category: " + Category + "\nMinAge: " + MinAge + "\nDescription: " + Description + " ProduceDate: " + ProduceDate + "\n----------- Manufacturer Data ---------\n" + "Manufacturer Name: " + ManufacturerData.Name + " LicenseNumber " + ManufacturerData.LicenseNumber + "\nAddress: " + ManufacturerData.Address;
        }
    }
}
