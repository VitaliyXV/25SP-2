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
              

        public DairyCreator(Dairy newDairy)
        {
            _baseDairy = newDairy;
        }

        public Item CreateItem(IItemSettings settings = null)
        {
            if (settings == null)
            {
                return _baseDairy.Clone();
            }
            else
            {
                return new Dairy(settings);
            }
        }

        public Type GetItemType()
        {
            return _baseDairy.GetType();
        }
    }
}
