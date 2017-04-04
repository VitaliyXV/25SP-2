using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public abstract class Item : IItemClonable
    {
        public string Name { get; protected set; }
        public float Price { get; protected set; }
        public CategoryType Category { get; protected set; }
      
        public Item()
        {
        }
        
        public Item(string name, float price, CategoryType category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
       
        public abstract Item Clone();
    }

}
