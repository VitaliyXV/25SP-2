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
                _factories.Add(newFactory);
        }

        public void RemoveFactory(IItemCreator newFactory)
        {
                _factories.Remove(newFactory);
        }

        public Item GetItem<T>(IItemSettings settings = null)
        {
            return _factories.FirstOrDefault(x => x.GetItemType() == typeof(T)).CreateItem(settings);
        }


    }
}
