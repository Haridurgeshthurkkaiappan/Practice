using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class swap
    {
        public void interchange1()
        {
            Console.WriteLine("enter the a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the b value");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(" the swapped value is "+a);
            Console.WriteLine(" the swapped value is " + b);





        }
        public void interchange2()
        {
            Console.WriteLine("enter the a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the b value");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(" the swapped value is " + a);
            Console.WriteLine(" the swapped value is " + b);





        }
    }
}
