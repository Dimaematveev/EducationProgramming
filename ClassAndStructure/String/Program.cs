using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string ddd = "dwefewfwefwef";
            const long COUNT = 10000;

            string[] strs = new string[COUNT];
            for (int i = 0; i < COUNT; i++)
            {
                strs[i] = ddd;
            }

            Console.ReadKey();
        }
    }
}
