using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    abstract class Item : IItemClonable
    {
        public string Name { get; protected set; }
        public float Price { get; protected set; }
        public CategoryType Category { get; protected set; }
    }
}
