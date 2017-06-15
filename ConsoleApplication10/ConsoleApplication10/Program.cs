using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w= double.Parse(Console.ReadLine());
            var row = 120;
            var buro = 70;
            Console.WriteLine((h * 100) / row + ((w * 100) - 100) / buro - 3);
            }
         




        }
    }
