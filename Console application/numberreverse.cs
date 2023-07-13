using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class numberreverse
    {
        public void reverse()
        {
            Console.WriteLine("enter the number to be reversed");
            int num= Convert.ToInt32(Console.ReadLine());
            int r = 0;
            while(num>0)
            {
                r = (r * 10) + num % 10;
                num = num / 10;
            }
            Console.WriteLine(r);
        }
    }
}
