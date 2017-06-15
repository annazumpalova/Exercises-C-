using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = double.Parse(Console.ReadLine());
            var t1 = double.Parse(Console.ReadLine());
            var t2 = double.Parse(Console.ReadLine());
            var t3 = double.Parse(Console.ReadLine());
            double first = s * (t1 / 60);
            double secondspeed = s + 0.10 * s;
            double plus = secondspeed * (t2 / 60);
            double thirdspeed = secondspeed - (0.05 * secondspeed);
            double minus = thirdspeed * (t3 / 60);
            Console.WriteLine("{0:F2}", first + plus + minus);
           

        }
    }
}
