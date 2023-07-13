using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class factorial
    {
        public factorial()
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            for (int i=1;i<=a;i++)
            {
                b = b * i;
            }
            Console.WriteLine(" the factorial number is"+b);

        }


    }
}
