using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Builder
{
    public class Director
    {
        private List<IBuilder> builders;
        public Director()
        {
            builders = new List<IBuilder>();
        }

        public void AddBuilder(IBuilder newBuilder)
        {
                builders.Add(newBuilder);
        }

        public void RemoveBuilder(IBuilder builder)
        {
            builders.Remove(builder);
        }

        public IItemBox ConstructItemBox<T>()
        {
            return builders.FirstOrDefault(x => x.GetBoxType() == typeof(T)).GetItemBox();
        }
    }
}
