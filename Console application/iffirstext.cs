using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
   partial class iffirst
    {
        public void m2()
        {
            Console.WriteLine("\n enter the value 1");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("\n the value  is greater than 10");

            }
            else
            {
                Console.WriteLine("\n the value  is smaller than 10");

            }

        }
    }
}
