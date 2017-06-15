using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtplosh = int.Parse(Console.ReadLine());
            var widthploch = double.Parse(Console.ReadLine());
            var lenghtploch = double.Parse(Console.ReadLine());
            var widthbench = int.Parse(Console.ReadLine());
            var lenghtbench = int.Parse(Console.ReadLine());
            int areaplosh;
            areaplosh = lenghtplosh * lenghtplosh;
            int areabench;
            areabench = widthbench * lenghtbench;
            double areaploch;
            int time = 2;
            areaploch = widthploch * lenghtploch;
            Console.WriteLine((areaplosh - areabench) / areaploch);
            Console.WriteLine(((areaplosh - areabench) / areaploch)*time/10);

        }
    }
}
