using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    class GameCreator:IItemCreator    
    {
        private Game newgame;

        public void GameCreator()
        {
            newgame = new Game();
        }

        public Item CreateItem()
        {            
            return newgame.Clone();
        }
    }
}
