﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Builder
{
    class ItemBoxList : IItemBox
    {
        public List<Item> Items { get; set; }
        public ItemBoxList()
        {
            Items = new List<Item>();
        }
    }
}
