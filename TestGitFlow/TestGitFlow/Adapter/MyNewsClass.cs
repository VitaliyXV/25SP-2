using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Adapter
{
    class MyNewsClass
    {
        public int id { get; set; }
        public string name { get; set;}
        public string text { get; set; }

        public List<string> comments = new List<string>();

        public MyNewsClass()
        {

        }
        public MyNewsClass(int id, string name, string text)
        {
            this.id = id;
            this.name = name;
            this.text = text;
        }
    }
}
