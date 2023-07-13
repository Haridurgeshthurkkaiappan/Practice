using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class userinfo
    {

        public void Space()
        {
            string f = "hari";
            string g = "durgesh";
            Console.WriteLine(f + g);
        }

        public void Detailes()
        {
            Console.WriteLine("enter your first name");
            string a = Console.ReadLine();
            Console.WriteLine("enter your last name");
            string b = Console.ReadLine();
            Console.WriteLine("enter your email id");
            string c = Console.ReadLine();

            Console.WriteLine("the user info is " +a + b + c);
        }

    }
}
