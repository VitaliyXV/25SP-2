using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    class ToyCreator: IItemCreator
    {
        public Item CreateItem()
        {
           return new Toy();
        }
    }
}
