using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Compozit;

namespace TestGitFlow.Model
{
    public abstract class Item : IItemClonable, IItemComponent 
    {
        public string Name { get; protected set; }
        public float Price { get; protected set; }
        public CategoryType Category { get; protected set; }

        private List<IItemComponent> childList = new List<IItemComponent>();
      
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


        public void AddChild(IItemComponent itemComponent)
        {
            childList.Add(itemComponent);
        }

        public void RemoveChild(IItemComponent itemComponent)
        {
            childList.Remove(itemComponent);
        }

        public List<IItemComponent> GetChildList()
        {
            return childList;
        }
    }

}
