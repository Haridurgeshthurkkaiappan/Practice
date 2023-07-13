using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class Constructors
    {
        int tamil, English, maths, science, ss,total,avg;
        public Constructors()
        {
            Console.WriteLine("\n enter your tamil mark");
             tamil = Convert.ToInt16 (Console.ReadLine());
            Console.WriteLine("\n enter your english mark");
             English = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n enter your maths mark");
             maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n enter your science mark");
             science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n enter your ss mark");
             ss = Convert.ToInt16(Console.ReadLine());
        }
        public Constructors(int tamil,int English,int maths,int science,int ss)
        {
            this.tamil = tamil;
            this.English = English;
            this.maths = maths;
            this.science = science;
            this.ss = ss;
        }
        public void Total()
        {
             total = tamil + English + maths + science + ss;
            Console.WriteLine($"your total mark is{total} ");
        }

        public void Avg()
        {
            int avg = total / 5;
            Console.WriteLine($"your avg mark is {avg}");

        }



    }
}
