using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    static class staticclass
    {

        static int a = 30, b = 2, c = 30, d = 40, e = 10, f = 60;

        //creating method for arithmatic operator
        public static void Arithmatic()
        {
            Console.WriteLine($"for addition{ a + b}");
            Console.WriteLine($"for sub{ a - b}");
            Console.WriteLine($"for multplication{ a * b}");
            Console.WriteLine($"for division{ a / b}");
            Console.WriteLine($"for modulo{ a % b}");
        }
        
    }
}
