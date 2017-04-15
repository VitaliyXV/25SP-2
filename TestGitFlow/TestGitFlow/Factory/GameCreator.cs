using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    public class GameCreator:IItemCreator    
    {
        private Game newgame;

        public GameCreator()
        {
            newgame = new Game();
        }

        public Item CreateItem()
        {            
            return newgame.Clone();
        }


        public Type GetItemType()
        {
            return newgame.GetType();
        }

        public Item CreateItem(IItemSettings settings = null)
        {
            throw new NotImplementedException();
        }
    }
}
