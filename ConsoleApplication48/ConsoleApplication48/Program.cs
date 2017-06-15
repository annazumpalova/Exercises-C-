using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            for(int i=1;i<=n;i++) {
                var p = int.Parse(Console.ReadLine());
                if (p<=5) {
                    sum = sum + p;
                } else if(p>=6 && p<=12) {
                    sum1 = sum1 + p;
                }

                Console.WriteLine("{0:F2}%", sum/people*100)
            }
        }
    }
}
