using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class fibinosesSeries
    {

        public fibinosesSeries()
        {
            int a = 0;
            int b = 1;
            int temp = 0;
            Console.WriteLine("enter the number upto which the fibinoses series should display");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);

           
            for(int i=0;i<=c;i++)
            {
                temp = a + b;
                a = b;
                b = temp;

                Console.WriteLine(temp);
            }
        }
         
    }
}
