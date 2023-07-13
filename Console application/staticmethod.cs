using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class staticmethod
    {
        public static int a = 40;
        public int b = 50;
        public static void m1()
        {
            Console.WriteLine($"static {a}");

        }

        public void m2()
        {
            Console.WriteLine($"non static {b}");


        }
    }
}
