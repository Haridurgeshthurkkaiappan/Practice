using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class vowles_while
    {
        public void vowles1()
        {
            Console.WriteLine("enter the sentence");
            string a = Console.ReadLine();
            a = a.ToLower();
            int temp = 0;//vowles
            int temp1 = 0;//consonent
            int i = 0;
            while( i < a.Length)
            {

                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    temp++;
                }
                else
                {
                    temp1++;
                }
                i++;

            }
            Console.WriteLine($"vowles {temp}");
            Console.WriteLine($"consolent {temp1}");
        }
    }
}
