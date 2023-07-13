using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class array_forloop
    {
        public void array()
        {
            int[] a = new int[5];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;
            int temp=0;
            for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
                temp = temp + a[i];


            }
            Console.WriteLine(temp);
                
        }
        public void dinamic()
        {
            
            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for (int b=0;b<a.Length;b++ )
            {
                Console.WriteLine("enter the value");
                a[b]= Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                temp = temp + a[i];


            }
            Console.WriteLine(temp);

        }
    }
}
