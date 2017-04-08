using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Builder
{
    public class ItemBox
    {
        public List<Item> Items { get; set; }

        public ItemBox()
        {
            Items = new List<Item>();
        }

    }
}
