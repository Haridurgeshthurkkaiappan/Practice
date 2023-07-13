using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class ArraySorting
    {

        public void accending()
        {
            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("enter the value");
            for (int b = 0; b < a.Length; b++)
            {

                a[b] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    int temp = 0;
                    if (a[i] >= a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("accending order");

            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[k]);
            }
        }

        public void decending()
        {
            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("enter the value");
            for (int b = 0; b < a.Length; b++)
            {

                a[b] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    int temp = 0;
                    if (a[i] <= a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("decending order");
            for (int k = 0; k < a.Length; k++)
            {
              
                Console.WriteLine(a[k]);
            }
        }

        public void choose()
        {
            int c = 0;
            do
            {
                Console.WriteLine("choose the option");
                Console.WriteLine("0.exit");
                Console.WriteLine("1.accending");
                Console.WriteLine("2.deccending");

                Console.WriteLine("enter the option");
                c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 0:
                        Console.WriteLine("exiting");
                        break;

                    case 1:
                        ArraySorting obj = new ArraySorting();

                        obj.accending();
                        break;
                    case 2:
                        ArraySorting obj1 = new ArraySorting();

                        obj1.decending();
                        break;


                }

            } while (c != 0);




            
          }
    }
}
