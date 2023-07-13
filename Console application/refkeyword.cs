using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class refkeyword
    {
        public void R1(ref string a)
        {
            a = "hari";
        }
        public void R2()
        {
            string value = String.Empty;

           R1(ref value);
            Console.WriteLine( "  The parameter value passed in method"    + value);
        }
    }
}
