using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class Constructorstypes
    {
        public int c = 25;
        public Constructorstypes()
        {
            Console.WriteLine($"{c}");
        
        
        }

        public Constructorstypes(int a)
        {
            Console.WriteLine($"{a}");



        }

       static Constructorstypes()
        {

            Console.WriteLine("static");


        }





    }
}
