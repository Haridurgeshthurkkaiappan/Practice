using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class basic_forloop
    {
      public void forloop()
        {
            Console.WriteLine("enter the number");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int a=b;a>=0;a--)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("even number"+a);
                }
                else
                {
                    Console.WriteLine("odd number" + a);

                }
            }
        }
    }
}
