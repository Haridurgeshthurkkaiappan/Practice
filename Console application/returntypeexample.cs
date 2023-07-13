using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class value
    {
     
        public int amount()
        {
            Console.WriteLine("enter the apple kgs");
            int applekg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the apple cost");
            int apple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the orange kgs");
            int orangekg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the orange cost");
            int orange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the tomato kgs");
            int tomatokg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the tomato cost");
            int tomato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the potato kgs");
            int potatokg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the potato cost");
            int potato = Convert.ToInt32(Console.ReadLine());




            int costa = applekg * apple + orangekg * orange + tomatokg * tomato + potatokg * potato;
            return costa;

        }

    }
    class final
    {
        public void Total()
        {


            value obj1 = new value();
            int total = obj1.amount();
            Console.WriteLine($"total cost is {total}" );
        }

    }
}
