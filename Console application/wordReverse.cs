using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class wordReverse
    {
        public wordReverse ()
            {
            Console.WriteLine("enter the sentance");
            string a = Console.ReadLine();
            string [] b = a.Split(' ');
            for (int i=b.Length-1;i>=0;i--)
            {
                Console.Write(b[i]+' ');
            }
        }
    }
}
