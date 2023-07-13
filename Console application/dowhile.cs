using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class dowhile
    {
        public dowhile()
            
        {
            int a = 0;
            do
            {
                Console.WriteLine("choose the option");
                Console.WriteLine("0.exit");
                Console.WriteLine("1.leo");
                Console.WriteLine("2.vikram");
                Console.WriteLine("3.kaithi");

                Console.WriteLine("enter the option");
                 a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 0:
                        Console.WriteLine("exiting");
                        break;

                    case 1:
                        Console.WriteLine("now you can watch leo movie");
                        break;
                    case 2:
                        Console.WriteLine("now you can watch vikram movie");
                        break;
                    case 3:

                        Console.WriteLine("now you can watch kaithi movie");
                        break;
                    default:
                        Console.WriteLine("you entered the invalid option");
                        break;
                }
            } while (a!=0);
        }
    }
}
