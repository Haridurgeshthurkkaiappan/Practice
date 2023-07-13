using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{

        class asis
        {
        public void askeyword()
        {
            object[] obj = new object[4];
            Console.WriteLine("enter something");
            obj[0] = Console.ReadLine();
            Console.WriteLine("enter something");
            obj[1] = Console.ReadLine();
            Console.WriteLine("enter something");
            obj[2] = Console.ReadLine();
            Console.WriteLine("enter something");
            obj[3] = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                string s = obj[i] as string;

                if (s == null)
                {
                    Console.Write("there is no string \n");

                }
                else
                {
                    Console.Write(" there is string \n");
                }
            }
        }
        public void IsKeyword()
        {
            Console.WriteLine("enter the value ");
            var n = Convert.ToInt32(Console.ReadLine());

            if (n is int)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            

        }
    }
    }

