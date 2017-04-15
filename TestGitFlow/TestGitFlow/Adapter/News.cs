using System;
using System.Collections.Generic;

namespace TestGitFlow.Adapter
{
    public class News
    {        
        public DateTime Date { get; set; }

        public string Theme { get; set; }

        public string Text { get; set; }

        public readonly List<string> Comments = new List<string>();
    }
}
