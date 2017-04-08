using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    class DairyCreator: IItemCreator
    {
        private Dairy _baseDairy;

        public DairyCreator()
        {
            _baseDairy = new Dairy();
        }

        public DairyCreator(Dairy newDairy)
        {
            _baseDairy = newDairy;
        }

        public Item CreateItem()
        {
            return _baseDairy.Clone();
        }

        public Type GetItemType()
        {
            return _baseDairy.GetType();
        }
    }
}
