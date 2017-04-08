using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestGitFlow.Model
{
    class Dairy : Item, IItemSettings
    {
        #region VARIABLES
        private Manufacturer _manufacturer;
        private DateTime _dateOfMade;
        private DateTime _endOfTerm;
        #endregion


        public Dairy(string name, float price, CategoryType category, DateTime dateOfMade, DateTime endOfTerm, Manufacturer manufacturer) : base(name, price, category)
        {

            Name = name;
            Price = price;
            Category = category;

            #region ASSERTS
            Assert.IsTrue(!string.IsNullOrEmpty(name), "name is null or empty");
            Assert.IsTrue(price > 0, "price must be more than zero");
            Assert.IsTrue(category != CategoryType.NONE, "no type");
            Assert.AreNotEqual(null, manufacturer, "manufacturer is null");
            #endregion
            _dateOfMade = dateOfMade;
            _endOfTerm = endOfTerm;
            _manufacturer = manufacturer;
        }

        public override Item Clone()
        {
            Manufacturer cloneManufacturer = new Manufacturer();
            cloneManufacturer.Name = _manufacturer.Name;
            cloneManufacturer.LicenseNumber = _manufacturer.LicenseNumber;
            cloneManufacturer.Address = _manufacturer.Address;

            Dairy cloneDairy = new Dairy(Name, Price, Category, _dateOfMade, _endOfTerm, cloneManufacturer);
            #region ASSERTS
            Assert.AreNotEqual(null, cloneDairy, "cloneDairy is null");
            #endregion
            return cloneDairy;
          
        }


        #region SETTERS AND GETTERS
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPrice(float price)
        {
            Price = price;
        }

        public Manufacturer GetManufacturer()
        {
            #region ASSERTS
            Assert.AreNotEqual(null, _manufacturer, "_manufacturer is null");
            #endregion
            return _manufacturer;
        }

        public void SetManufacturer(Manufacturer manufacturer)
        {
            #region ASSERTS
            Assert.AreNotEqual(null, manufacturer, "manufacturer is null");
            #endregion
            _manufacturer = manufacturer;
        }


        public void SetDateOfMade(DateTime dateOfMade)
        {
            _dateOfMade = dateOfMade;
        }

        public DateTime GetDateOfMade()
        {
            return _dateOfMade;
        }



        public void SetDateOfTermEnd(DateTime endTerm)
        {
            _endOfTerm = endTerm;
        }

        public DateTime GetDateOfTermEnd()
        {
            return _endOfTerm;
        }

        #endregion

        public override string ToString()
        {
            return "Dairy name: " + Name + "\nPrice: " + Price + "\nCategory: " 
                + Category.ToString() + "\nDate of made: " + _dateOfMade + "\nDate of term end : " 
                + _endOfTerm +  "\n----------- Manufacturer ---------\n" + "\nManufacturer Name: " + _manufacturer.Name
                + "\nLicenseNumber " + _manufacturer.LicenseNumber + "\nAddress: " + _manufacturer.Address;
        }
    }
}
