using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class variables
    {
        public void user()
        {
            Console.WriteLine("\n Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("\n Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter your Qualification");
            string qualification = Console.ReadLine();

            Console.WriteLine($"\n Name:{name} \n Age:{age} \n Qualification: {qualification}");

        }
        public void parameter(string name,int age,string qualification)
        {
            Console.WriteLine($"\n Name:{name} \n Age:{age} \n Qualification: {qualification}");

        }
    }
}
