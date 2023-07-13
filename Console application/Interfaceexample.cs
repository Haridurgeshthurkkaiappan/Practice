using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
  public  class amstrong1
    {
        public void amstrong2()
        {
            Console.WriteLine("enter the number ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int d = 0;


            while (a != 0)
            {
                int c = a % 10;
                d = d + (c * c * c);
                a = a / 10;
            }
            if (b == d)
            {
                Console.WriteLine("the number is amstrong number ");

            }
            else
            {
                Console.WriteLine("the number is not a amstrong number ");

            }
        }
    }

    interface Interfaceexample
    {
        public void amstrong2();


    }
    class strong:Interfaceexample
    {
             public void amstrong2()
        {
            amstrong1 obj = new amstrong1();
            obj.amstrong2();

        }
    }
}
