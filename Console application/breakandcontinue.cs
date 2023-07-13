using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class breakandcontinue
    {
        public void Break()
        {
            Console.WriteLine("enter the start value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the end  value");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a;i<=10000;i++)
            {
                if (i==b+1)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
        public void Continue()
        {
            Console.WriteLine("enter the start value to be left");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the end  value to be left");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= 10; i++)
            {
                if (i <= b )
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
