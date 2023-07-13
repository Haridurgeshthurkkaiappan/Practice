using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    public class Marks
    {
        public int tamil, english, maths, science, ss,total;

        public void Total()
        {
            total = tamil + english + maths + science + ss;
            Console.WriteLine($"your total mark is{total} ");
        }


        public void Avg()
        {
            int avg = total / 5;
            Console.WriteLine($"your avg mark is {avg}");

        }
    }

    class  constructors
    {
        public constructors(Marks m)
        {
            Console.WriteLine($"tamil mark is {m.tamil}");
            Console.WriteLine($"english mark is {m.english}");
            Console.WriteLine($" maths mark is {m.maths}");
            Console.WriteLine($"science mark  is {m.science}");
            Console.WriteLine($"ss is {m.ss}");
        }
        

    }
}
