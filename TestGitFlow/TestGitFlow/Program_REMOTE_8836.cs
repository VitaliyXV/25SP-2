using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanLib;

namespace TestGitFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            IvanLib.IvanLib ivan = new IvanLib.IvanLib();

            Console.WriteLine("Hello World! " + ivan.GetData());
        }
    }
}
