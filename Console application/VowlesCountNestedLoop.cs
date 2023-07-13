using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{ 
    class VowlesCountNestedLoop
    {
     public   VowlesCountNestedLoop()
        {
            Console.WriteLine("enter the sentence");
            string a = Console.ReadLine();
            a = a.ToLower();
            string vow = "aeiou";
            //char[] vow = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for(int i=0;i<vow.Length;i++)
            {
                int temp = 0;


                for (int j = 0; j < a.Length; j++)
                {
                    if (vow[i] == a[j])
                    {
                        temp++;
                    }
                }

                Console.WriteLine($"the count of { vow[i]} is {temp}");
            }
        }

    }
}
