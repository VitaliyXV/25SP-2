<<<<<<< HEAD
﻿using EvgenLibrary;
using System;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanLib;
>>>>>>> develop

namespace TestGitFlow
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello World!");
            StringMaker sm = new StringMaker();
            Console.WriteLine(sm.GetString());
=======
            IvanLib.IvanLib ivan = new IvanLib.IvanLib();

            Console.WriteLine("Hello World! " + ivan.GetData());
>>>>>>> develop
        }
    }
}
