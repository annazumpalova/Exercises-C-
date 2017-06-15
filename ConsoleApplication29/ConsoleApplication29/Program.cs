using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if(a+b==c) {
                Console.WriteLine("{0} + {1} = {2}", b, a , c);
            } else if(a+c==b) {
                Console.WriteLine("{0} + {1} = {2}", a, c, b);
            } else if(c+b==a) {
                Console.WriteLine("{0} + {1} = {2}", c, b, a);
            } else {
                Console.WriteLine("No");
            }
        }
    }
}
