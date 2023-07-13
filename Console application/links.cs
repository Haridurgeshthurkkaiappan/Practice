using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class links
    {
        public links()


        {

            List<string> lst = new List<string>();
            lst.Add("Ronaldo");
            lst.Add("messi");
            lst.Add("modric");
            lst.Add("kroos");

           
            if (lst.Any(a => a == "kroos" || a == ""))
            {

            }

            var soura = lst.Find(x => x.ToLower() == "sourav".ToLower());

            lst.First(x => x.Contains("S"));

            var re = lst.FirstOrDefault(x => x.Contains("x"));

            if (re != null)
                re = "";

            var list = lst.Where(x => x == "suresh").ToArray();

            var arryBool = lst.Select(x => x.Contains("S")).ToArray();

            lst.Distinct();
            lst.Min();
            lst.Max();

            lst.ForEach(x =>
            {
                if (x == "sure")
                    x = "ramesh";

            });

        }
    }
}
