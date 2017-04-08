using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Builder
{
    class BuiderItemList : IBuilder
    {
        private ItemBoxList itemList;

        public void AddItem(Item item)
        {
            if (itemList == null) itemList = new ItemBoxList();
            itemList.Items.Add(item);
            
        }

        public IItemBox GetItemBox()
        {
            return itemList;
        }
    }
}
