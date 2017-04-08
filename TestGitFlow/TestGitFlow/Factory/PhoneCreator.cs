using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    public class PhoneCreator : IItemCreator
    {
        private Phone phone;

        public PhoneCreator()
        {
            this.phone = new Phone();
        }
        public PhoneCreator(Phone phone)
        {
            this.phone = phone;
        }
        public Item CreateItem(IItemSettings settings)
        {
            if (settings == null) return phone.Clone();
            PhoneSettings set = settings as PhoneSettings;
            return new Phone(set.Name, set.Price, set.Category, set.Type, set.BrandName, set.ReleaseDate, set.DisplaySize, set.OS, set.SimCardQuantity, set.RAM, set.ROM, set.Camera, set.BatteryCapacity, set.Comm);
        }

        public Type GetItemType()
        {
            return phone.GetType();
        }
    }
}
