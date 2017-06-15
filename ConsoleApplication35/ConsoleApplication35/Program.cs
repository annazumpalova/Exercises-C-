using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var hranakg = int.Parse(Console.ReadLine());
            var kuchehrana = double.Parse(Console.ReadLine());
            var kotkahrana = double.Parse(Console.ReadLine());
            var kostenurkahrana = double.Parse(Console.ReadLine());
            var kuche = days * kuchehrana;
            var kotka = days * kotkahrana;
            var kostenurka = (days * kostenurkahrana) / 1000;
            var obshtohrana = kostenurka + kuche + kotka;
            if(obshtohrana<hranakg) {
                var hranaoshte = Math.Floor(hranakg - obshtohrana);
                Console.WriteLine("{0} kilos of food left.",hranaoshte );
            } else {
                var hranadve = Math.Ceiling(obshtohrana - hranakg);
                Console.WriteLine("{0} more kilos of food are needed.",hranadve );
            }

        }
    }
}
