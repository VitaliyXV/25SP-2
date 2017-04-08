using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Builder
{
    public class ItemBoxOneItem : IItemBox
    {
        public Item Item { get; set; }
    }
}
