using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double mikrobus = 0;
            double kamion = 0;
            double vlak = 0;
            double obshtotona=0;
            for (int i=0; i<n; i++) {
                var m = int.Parse(Console.ReadLine());
                obshtotona += m;
               if(m<=3) {
                    mikrobus += m;
               } else if(m>=4 && m<=11) {
                    kamion += m;
               } else if(m>=12) {
                    vlak += m;
               }
                
            }
            double srednonaton = (mikrobus * 200 + kamion * 175 + vlak * 120) / obshtotona;
            Console.WriteLine("{0:F2}", srednonaton);
            Console.WriteLine("{0:F2}%", mikrobus / obshtotona * 100);
            Console.WriteLine("{0:F2}%", kamion / obshtotona * 100);
            Console.WriteLine("{0:F2}%", vlak / obshtotona * 100);

        }
    }
}
