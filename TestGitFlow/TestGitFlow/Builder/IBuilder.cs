using TestGitFlow.Model;
namespace TestGitFlow.Builder
{
    public interface IBuilder
    {
        void AddItem(Item item);
        ItemBox GetItemBox();

    }
}
