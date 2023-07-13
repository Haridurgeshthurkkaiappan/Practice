using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class word_count
    {
        public void count()
        {
            Console.WriteLine("enter the sentance");
            string a = Console.ReadLine();
            a = a.Trim();
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    temp++;
                }
            }
            int b = temp + 1;
            Console.WriteLine("no of words are " + b);
        }
        public void countsplit()
        {
            Console.WriteLine("enter the sentance");
            string a = Console.ReadLine();
            var s = a.Split(' ');
            Console.WriteLine("no of words are" +s.Length);


        }
    }
}
