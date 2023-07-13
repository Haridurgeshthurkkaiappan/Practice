using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    partial class iffirst
    {
        public void m3()
        {
            Console.WriteLine("\n enter the value");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 4==0)
            {
                Console.WriteLine("\n it is leep year");

            }
            else
            {
                Console.WriteLine("\n  it is not leep year");

            }

        }
    }
}
