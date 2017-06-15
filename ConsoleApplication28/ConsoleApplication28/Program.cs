using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var m = Math.Abs(point - first);
            var n = Math.Abs(second - point);
            if ((first<point && point<second) || (first>point && second<point )) {
                Console.WriteLine("in");
                if(m<n) {
                    Console.WriteLine(m);
                } else {
                    Console.WriteLine(n);
                }
            } else {
                Console.WriteLine("out");
                if (m < n)
                {
                    Console.WriteLine(m);
                }
                else
                {
                    Console.WriteLine(n);
                }

            }
        }
    }
}
