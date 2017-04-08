using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    class PhoneCreator : IItemCreator
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

        public Item CreateItem()
        {
            return phone.Clone();
        }
    }
}
