using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class product
    {
        public string name { get; set; }
        public double price { get; set; }
        public double netweight { get; set; }
        public double offerprice { get;set;}
    }

    class property
    {
        public void productdetails()
        {
            product pro = new product();
            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            product [] a = new product [size];
            for (int b = 0; b < a.Length; b++)
            {
                a[b] = new product();

                Console.WriteLine("enter the name");
                a[b].name = Console.ReadLine();
                Console.WriteLine("enter the price");
                a[b].price =Convert.ToDouble( Console.ReadLine());
                Console.WriteLine("enter the net weight");
                a[b].netweight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the offer price");
                a[b].offerprice = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($" the name is {a[i].name}");
                Console.WriteLine($" the pric is {a[i].price}");
                Console.WriteLine($" the net weight is  {a[i].netweight}");
                Console.WriteLine($" the offer price is  {a[i].offerprice}");
            }



        }
    }

}

