using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHornetWings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = decimal.Parse(Console.ReadLine());
            var p = long.Parse(Console.ReadLine());

            decimal distance = (n / 1000) * m;
            decimal hornetFlapsSeconds = n / 100;
            decimal restForfive = (n / p) * 5;
            decimal result = restForfive + hornetFlapsSeconds;

            Console.WriteLine("{0:F2} m.", distance);
            Console.WriteLine("{0} s.", result);

        }
    }
}
