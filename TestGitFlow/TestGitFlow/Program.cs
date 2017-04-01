using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using ConsoleLogDll;

namespace TestGitFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            IvanLib ivan = new IvanLib();

            Console.WriteLine("Hello World! " + ivan.GetData());
            Logger log = new Logger();

        }
    }
}
