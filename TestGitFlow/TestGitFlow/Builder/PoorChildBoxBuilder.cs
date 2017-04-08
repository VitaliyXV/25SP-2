using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Builder
{
    public class PoorChildBoxBuilder: IBuilder
    {
        private ItemBoxOneItem _box;

        public PoorChildBoxBuilder()
        {
            _box = new ItemBoxOneItem();
        }
        public void AddItem(Model.Item item)
        {
            _box.Item = item;
        }

        public IItemBox GetItemBox()
        {
            return _box;
        }
    }
}
