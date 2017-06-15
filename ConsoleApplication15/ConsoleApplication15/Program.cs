using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
                        int mayApart = 65;
            double septStudio = 75.20;
            double septApart = 68.70;
            int augustApart = 77;
            int augustStudio = 76;

            if (month=="May" || month=="October") {
                    if(n>7 && n<14) {
                    double newmayStudio = 50 - 50 * 0.05;
                    Console.WriteLine("Apartament:{0:F2}lv", mayApart * n);
                    Console.WriteLine("Studio:{0:F2}lv", newmayStudio * n);
            } else if(n>=14) {
                    double newmayStudio1 = 50 - 50 * 0.3;
                    double newmayApart = 65 - 65 * 0.1;
                    Console.WriteLine("Apartament:{0:F2}lv", newmayApart * n);
                    Console.WriteLine("Studio:{0:F2}lv", newmayStudio1 * n);
            } 
            } if(month=="June" || month=="September") {
                if (n >= 14) {
                    double newJuneStudio = septStudio-septStudio* 0.2;
                    double newJuneApart = septApart-septApart* 0.1;
                    Console.WriteLine("Apartament:{0:F2}lv", newJuneApart * n);
                    Console.WriteLine("Studio:{0:F2}lv", newJuneStudio * n);
            } else if(n<14) {
                    Console.WriteLine("Apartament:{0:F2}lv", septApart*n);
                    Console.WriteLine("Studio:{0:F2}lv", septStudio*n);
            }
            } if(month=="July" && month=="August") {
            if(n>=14) {
                    double newAugApart = augustApart-augustApart* 0.1;
                    Console.WriteLine("Apartament:{0:F2}lv", newAugApart*n);
                    Console.WriteLine("Studio:{0:F2}lv", augustStudio* n);
            } else if(n<14){
                    Console.WriteLine("Apartament:{0:F2}lv", augustApart* n);
                    Console.WriteLine("Studio:{0:F2}lv", augustStudio * n);
                }
            }
        }
    }
}
