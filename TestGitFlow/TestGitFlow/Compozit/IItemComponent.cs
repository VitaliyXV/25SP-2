using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Compozit
{
    public interface IItemComponent
    {
        void AddChild(IItemComponent itemComponent);
        void RemoveChild(IItemComponent itemComponent);
        List<IItemComponent> GetChildList();
    }
}
