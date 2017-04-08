﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    class ToyCreator: IItemCreator
    {
        private Toy _baseToy;

        public ToyCreator(Toy newToy)
        { 
            _baseToy = newToy;
        }
        public Item CreateItem()
        {
            return _baseToy.Clone();
        }
    }
}
