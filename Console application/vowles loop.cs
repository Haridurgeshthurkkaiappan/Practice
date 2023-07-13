using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class vowles_loop
    {
        public void vowles()
        {
            Console.WriteLine("enter the sentence");
            string a = Console.ReadLine();
            a = a.ToLower();
            int temp = 0;//vowles
            int temp1 = 0;//consonent
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    temp++; 
                }
                else
                {
                    temp1++;
                }
                 

            }
            Console.WriteLine($"vowles {temp}");
            Console.WriteLine($"consolent {temp1}");
        }

        public void printvowles()
        {
            Console.WriteLine("enter the sentence");
            string a = Console.ReadLine();
            a = a.ToLower();
            int temp = 0;//vowles
            int temp1 = 0;//consonent
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    Console.WriteLine(a[i]);
                    temp++;
                }
                else 
                {

                    temp1++;
                }


            }
            Console.WriteLine($"vowles {temp}");
            Console.WriteLine($"consolent {temp1}");

        }
        public void printconsonent()
        {
            Console.WriteLine("enter the sentence");
            string a = Console.ReadLine();
            a = a.ToLower();
            int temp = 0;//vowles
            int temp1 = 0;//consonent
            for (int i = 0; i < a.Length; i++)
            {

                if (!(a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u'))
                {
                    Console.WriteLine(a[i]);

                    temp++;
                }
                else
                {
                    temp1++;
                }

                   
            }
            Console.WriteLine($"vowles {temp}");
            Console.WriteLine($"consolent {temp1}");
        }

    }
}
