using System;
using TestGitFlow.Model;
namespace TestGitFlow.Builder
{
    public interface IBuilder
    {
        void AddItem(Item item);
        IItemBox GetItemBox();

        Type GetBoxType();
    }
}
