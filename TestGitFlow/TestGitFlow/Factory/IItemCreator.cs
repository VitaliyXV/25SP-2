using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    public interface IItemCreator
    {
        Item CreateItem(IItemSettings settings = null);
        Type GetItemType();

    }
}
