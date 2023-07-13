using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class typecasting
    {
        int F;
        public void Readmark()
        {

            Console.WriteLine("enter your tamil mark");
            string a = Console.ReadLine();
            Console.WriteLine("enter your english mark");
            string b = Console.ReadLine();
            Console.WriteLine("enter your maths mark");
            string c = Console.ReadLine();
            Console.WriteLine("enter your science mark");
            string d = Console.ReadLine(); 
            Console.WriteLine("enter your ss mark");
            string e = Console.ReadLine();

            int tamil = Convert.ToInt16(a);
            int english = Convert.ToInt16(b);
            int maths = Convert.ToInt16(c);
            int science = Convert.ToInt16(d);
            int ss = Convert.ToInt16(e);
             F = tamil + english + maths + science + ss;
            Console.WriteLine("your total mark is " + F);
           // return F;
        }
        public void calculateavg()
        {

            //typecasting obj = new typecasting();
            //int Total=obj.Readmark();
            Console.WriteLine("your avg is"+ F / 5);

        }

    }
}
