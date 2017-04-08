using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Builder
{
    public class TreeBoxBuilder : IBuilder
    {

       private TreeItemBox _box;

       public TreeBoxBuilder()
        {
            _box = new TreeItemBox();
        }
        public void AddItem(Model.Item item)
        {
            _box.Items.Add(item);
            _box.Items.Last().AddChild(new Toy());
        }

        public IItemBox GetItemBox()
        {
            return _box;
        }

        public Type GetBoxType()
        {
            return _box.GetType();
        }
    }
}
