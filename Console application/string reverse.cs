using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class string_reverse
    {
        
        
            public  void Reverse_String()
            {
                Console.WriteLine("enter a string to Print Reverse");
                String s = Console.ReadLine();

                string temp = String.Empty;

                for (int i = 0; i < s.Length; i++)
                {
                    temp = s[i] + temp;
                }
                Console.WriteLine("Reveresed string is   " + temp);

                if (temp == s)
                {
                    Console.WriteLine("This string is palindrone");

                }
                else
                {
                    Console.WriteLine("This string is not a palindrone");
                }
            }

        }
    
}
