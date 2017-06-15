using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVeg = double.Parse(Console.ReadLine());
            var priceFruit = double.Parse(Console.ReadLine());
            var kilogramVeg = int.Parse(Console.ReadLine());
            var kilogramFruit = int.Parse(Console.ReadLine());
            var fruit = priceFruit * kilogramFruit;
            var vegetable = priceVeg * kilogramVeg;
            var allkilogram = (fruit + vegetable) / 1.94;
            Console.WriteLine(allkilogram);
        }
    }
}
