using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2= int.Parse(Console.ReadLine());
            var y2= int.Parse(Console.ReadLine());
            var x3= int.Parse(Console.ReadLine());
            var y3 = y2;
            var aStrana =Math.Abs(x2 - x3);
            var visochina = Math.Abs(y1 - y2);
            var lice = (aStrana * visochina) / 2;
            Console.WriteLine("{0:F1}", lice);

        }
    }
}
