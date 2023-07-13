using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class student
    {
        public string Name;
        public int Tamil;
        public int english;
        public int maths;
    }

    class mark
    {
        public int total;
        public int total1;
        public int avg;
        public int avg1;


        public void Marks()
        {
            student[] s = new student[5];
            s[0] = new student();
            Console.WriteLine("enter your name");
            s[0].Name = Console.ReadLine();
            Console.WriteLine("enter your TAMIL MARK");
            s[0].Tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your ENGLISH MARK ");
            s[0].english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your MATHS MARK");
            s[0].maths = Convert.ToInt32(Console.ReadLine());

            s[1] = new student();
            Console.WriteLine("enter your name");
            s[1].Name = Console.ReadLine();
            Console.WriteLine("enter your TAMIL MARK");
            s[1].Tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your ENGLISH MARK ");
            s[1].english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your MATHS MARK");
            s[1].maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(s[0].Name);
            total = s[0].Tamil + s[0].english + s[0].maths;
            Console.WriteLine(total);


            Console.WriteLine(s[1].Name);
            total1 = s[1].Tamil + s[1].english + s[1].maths;
            Console.WriteLine(total1);


            avg = total / 3;
            Console.WriteLine(avg);

            avg1 = total1 / 3;
            Console.WriteLine(avg1);

            if (avg >= 91 && avg <= 100)
            {
                Console.WriteLine(s[0].Name);
                Console.WriteLine("grad A");
            }

            else if (avg >= 81 && avg <= 90)
            {
                Console.WriteLine(s[0].Name);
                Console.WriteLine("grad B");
            }

            else if (avg >= 71 && avg <= 80)
            {
                Console.WriteLine(s[0].Name);
                Console.WriteLine("grad C");
            }
            else if (avg >= 50 && avg <= 70)
            {
                Console.WriteLine(s[0].Name);
                Console.WriteLine("grad D");
            }

            else if ( avg <= 49)
            {
                Console.WriteLine(s[0].Name);
                Console.WriteLine("grad F");
            }

            if (avg1 >= 91 && avg1 <= 100)
            {
                Console.WriteLine(s[1].Name);
                Console.WriteLine("grad A");
            }
            else if (avg1 >= 81 && avg1 <= 90)
            {
                Console.WriteLine(s[1].Name);
                Console.WriteLine("grad B");
            }

            else if (avg1 >= 71 && avg1 <= 80)
            {
                Console.WriteLine(s[1].Name);
                Console.WriteLine("grad C");
            }
            else if (avg1 >= 50 && avg1 <= 70)
            {
                Console.WriteLine(s[1].Name);
                Console.WriteLine("grad D");
            }

            else if (avg1 <= 49)
            {
                Console.WriteLine(s[1].Name);
                Console.WriteLine("grad F");
            }


        }

    }
    
    
    
    

    
}
