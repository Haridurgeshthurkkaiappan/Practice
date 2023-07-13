using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class A
    {
        public string Type()
        {
            string name = "hari";
            return name;
        }
    }
    class B
    {
        public void data()
        {
            A obj = new A();
            string value = obj.Type();
            Console.WriteLine(value);
        }
    }




















            
    
}
