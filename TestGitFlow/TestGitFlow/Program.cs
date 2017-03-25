using EvgenLibrary;
using System;

namespace TestGitFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringMaker sm = new StringMaker();
            Console.WriteLine(sm.GetString());
        }
    }
}
