using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Builder
{
    public class HappyChildBuilder: IBuilder
    {
        private ItemBox _box;
        public HappyChildBuilder()
        {
            _box = new ItemBox();
        }

        public void AddItem(Item item)
        {
            _box.Items.Add(item);
        }

        public ItemBox GetItemBox()
        {
            return _box;
        }
    }
}
