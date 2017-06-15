using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var duljinavmetri = h * 100;
            var shirinavmetri = w * 100-100;
            var redove =Math.Floor( duljinavmetri / 120);
            var biura = Math.Floor( shirinavmetri / 70);
            var broimesta = redove * biura - 3;
            Console.WriteLine(broimesta);
        }
    }
}
