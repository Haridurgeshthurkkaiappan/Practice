using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class operators
    {

        //decleraing global variable
        int a = 30, b = 2, c = 30, d = 40, e = 10, f = 60;

        //creating method for arithmatic operator
        public void Arithmatic()
        {
            Console.WriteLine( "for addition" + (a + b));
            Console.WriteLine("for subraction" + ( a - b));
            Console.WriteLine("for multiplication" + ( a * b));
            Console.WriteLine("for division" + ( a / b));
            Console.WriteLine("for modulo" + ( a % b));
        }
        //creating method for comparision  operator
        public void comparision()
        {
            Console.WriteLine( a == e);
            Console.WriteLine(c >= b);
            Console.WriteLine(d<=f);
            Console.WriteLine( a<d);
            Console.WriteLine( b>c);
        }
        //creating method for bitwise  operator

        public void bitwise()
        {
            Console.WriteLine("a++"+a++);
            Console.WriteLine("++a" + ++a);
            Console.WriteLine("final"+a);
            Console.WriteLine("b--"+ b--);
            Console.WriteLine("--b"+ --b);
            Console.WriteLine("final"+ b);
        }
        //creating method for logical  operator

        public void logical()
        {
            Console.WriteLine(a<=b && b<=c);
            Console.WriteLine(a >= b || b >= c);
            Console.WriteLine(!(a == e));


        }
        //creating method for assignment  operator

        public void assignment()
        {
            Console.WriteLine(a = 70);

        
            Console.WriteLine(a += 5);
        }
    }
}
