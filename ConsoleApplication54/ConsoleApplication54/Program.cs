using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static void Main(string[] args)
        {
            var subranipari = double.Parse(Console.ReadLine());
            var shirochina= double.Parse(Console.ReadLine());
            var duljine= double.Parse(Console.ReadLine());
            var strananatr= double.Parse(Console.ReadLine());
            var visochina= double.Parse(Console.ReadLine());
            var cenapl= double.Parse(Console.ReadLine());
            var maistor= double.Parse(Console.ReadLine());
            var ploshtpod = shirochina * duljine;
            var ploshtnaplochka = (strananatr * visochina) / 2;
            var neobhodimiplochki = Math.Ceiling(ploshtpod / ploshtnaplochka) + 5;
            var obshtasuma = neobhodimiplochki * cenapl + maistor;
            if(obshtasuma<subranipari) {
                Console.WriteLine("{0:F2} lv left.", subranipari - obshtasuma);
            } else if(obshtasuma>subranipari) {
                Console.WriteLine("You'll need {0:F2} lv more.", obshtasuma - subranipari);
            } else {
                Console.WriteLine();
            }
        }
    }
}
