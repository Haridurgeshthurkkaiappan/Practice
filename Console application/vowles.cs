using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class vowles
    {
        public void findvowles()
        {

            Console.WriteLine("enter the letter");
            char l = Convert.ToChar(Console.ReadLine());

            if (l=='a' || l == 'e' || l == 'i' || l == 'o' || l == 'u')
            {
                Console.WriteLine(" the letter is vowles");

            }
            else
            {
                Console.WriteLine(" the letter is not a vowles");

            }
        }
    }
}
