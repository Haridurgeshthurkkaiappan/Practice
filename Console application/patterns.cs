using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class patterns
    {
        public patterns()
        {
            Console.WriteLine("enter the upto value ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=a;i++)
                {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
}
