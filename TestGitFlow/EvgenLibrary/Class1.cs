using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvgenLibrary
{
    public class StringMaker
    {
        string str1 = "Hello!";
        string str2 = "How are you?";
        string str3 = "Goodluck!";

        public string GetString()
        {
            Random r = new Random(2);
            int x = r.Next();
            if (x == 0)
            {
                return str1;
            }
            else if (x == 1)
            {
                return str2;
            }
            else
            {
                return str3;
            }


        }
    }
}
