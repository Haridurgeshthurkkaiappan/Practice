using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class string_duplication
    {
        public void Duplicate()
        {
            Console.WriteLine("Enter the word to checkduplication");
            String s = Console.ReadLine();
            int count = 0;
            string temp = string.Empty;
            string duplicate = string.Empty;

            s = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {

                if (temp.Contains(s[i]))
                {

                    if (!(duplicate.Contains(s[i])))
                    {
                        duplicate = duplicate + s[i];
                        count++;
                    }
                }
                else
                {
                    temp = temp + s[i];

                }


            }
            Console.WriteLine("Number of characters in string" + s);
            Console.WriteLine($"Duplicate Characters Count is    {count}");
            Console.WriteLine("Duplicate characters are     " + duplicate);
            Console.WriteLine("Non Duplicate Characters are    " + temp);
            Console.WriteLine("Count of Non Duplicate Characters are    " + temp.Length);

        }
    }
}
