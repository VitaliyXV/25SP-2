using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Compozit;

namespace TestGitFlow.Builder
{
    public class TreeItemBox : IItemBox
    {
        public List<IItemComponent> Items { get; set; }
        public TreeItemBox()
        {
            Items = new List<IItemComponent>();
        }
    }
}
