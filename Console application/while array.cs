using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class while_array
    {
        public void dinamic1()
        {

            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int b = 0;
            while ( b < a.Length)
            {
                Console.WriteLine("enter the value");
                a[b] = Convert.ToInt32(Console.ReadLine());
                b++;
            }
            int temp = 0;
            int i = 0;
            while ( i < a.Length)
            {
                Console.WriteLine(a[i]);
                temp = temp + a[i];
                i++;


            }
            Console.WriteLine(temp);

        }
    }
}
