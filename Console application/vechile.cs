using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haritest
{
    class vechile
    {
        public string name;
        public string number;
        public string owner;
        public string insurencenumber;
        public string color;
        public string manufarturer;
    }

    class vechileinfo
    {
        private vechilereport vp;

        public vechileinfo()
        {
            var v = getvechileinfo();
            vp = new vechilereport(v);

        }
        public vechileinfo(string name)
        {
            Console.WriteLine(name);
            var v = getvechileinfo();
            vp = new vechilereport(v);

        }
        public void Getvechiledetails()
        {
            var p = vp.Getvechiledetails();
            Console.WriteLine($"owner name\t { p.name} \nvechile number\t {p.number}\n no of ownwers\t{p.owner}\ncolor of vechile\t{p.color}\ninsurence number\t{p.insurencenumber}\nname of manufacturer\t{p.manufarturer}");

        }

        private vechile getvechileinfo()
        {
            vechile s = new vechile();

            Console.WriteLine("enter name");
            s.name = Console.ReadLine();
            Console.WriteLine("enter vechile number ");
            s.number = Console.ReadLine();
            Console.WriteLine("enter no of owners "); 
            s.owner = Console.ReadLine();
            Console.WriteLine("enter insurence number");
            s.insurencenumber = Console.ReadLine();
            Console.WriteLine("enter color of vechile");
            s.color = Console.ReadLine();
            Console.WriteLine("enter the manufacturer name");
            s.manufarturer = Console.ReadLine();
            return s;
        }
        public vechile[] vechliedetails()
        {
            vechile[] vec = new vechile[2];
            vec[0] = getvechileinfo();
            vec[1] = getvechileinfo();
            return vec;
        }
    }
    class vechilereport
    {
        public vechile v;
        public vechilereport(vechile v)
        {
            this.v = v;
        }
        public vechile Getvechiledetails()
        {
            return v;
        }
    }
}
