using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    public class ItemFactory
    {
        private List<IItemCreator> _factories;
        public ItemFactory()
        {
            _factories = new List<IItemCreator>();
        }

        public void AddFactory(IItemCreator newFactory)
        {
            try
            {
                _factories.Add(newFactory);
                Console.WriteLine("Factory added");
            }
            catch
            {
                Console.WriteLine("Can't add factory");
            }
        }

        public void RemoveFactory(IItemCreator newFactory)
        {
            try
            {
                _factories.Remove(newFactory);
                Console.WriteLine("Factory removed");
            }
            catch
            {
                Console.WriteLine("Can't remove factory");
            }
        }

        public Item GetItem<T>()
        {
            try
            {
                return _factories.FirstOrDefault(x => x.GetItemType() == typeof(T)).CreateItem();
                //return null;
            }
            catch
            {
                Console.WriteLine("No factory with this item type");
                return null;
            }
        }
    }
}
