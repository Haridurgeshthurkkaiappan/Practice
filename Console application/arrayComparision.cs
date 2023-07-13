using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class arrayComparision
    {
        public arrayComparision()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5,6};
            int[] b = new int[] { 1, 2, 3, 4, 5,6 };
            int temp = 0;
            if (a.Length==b.Length)
            {
                for(int i =0;i<a.Length;i++)
                {
                    if (a[i] == b[i])
                    {
                        temp++;

                    }
                }
                if (temp==b.Length)
                {
                    Console.WriteLine(" same");

                }
                else
                {
                    Console.WriteLine("not same");
                }

            }
            else
            {
                Console.WriteLine("not same");
            }


        }

        public void dynamic()
        {
            Console.WriteLine("enter the size");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size1];
            for (int c = 0; c < a.Length; c++)
            {
                Console.WriteLine("enter the value");
                a[c] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("enter the size");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[size2];
            for (int c = 0; c < a.Length; c++)
            {
                Console.WriteLine("enter the value");
                b[c] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i]==b[i])
                    {
                        temp++;

                    }
                }
                if (temp == b.Length)
                {
                    Console.WriteLine(" same");

                }
                else
                {
                    Console.WriteLine("not same");
                }

            }
            else
            {
                Console.WriteLine("not same");
            }

        }
}
}
