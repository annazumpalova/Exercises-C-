using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
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
            double sum5 = 0;
            for (int i=0; i<n; i++) {
                var p = int.Parse(Console.ReadLine());
                sum = sum + p;
                if(p<=5) {
                    sum1 += p;
                  
                } else if(p>=6 && p<=12) {
                    sum2 += p;
                   
                } else if(p>=13 && p<=25) {
                    sum3 += p;
                   
                } else if(p>=26 && p<=40) {
                    sum4 += p;
                   
                } else if(p>=41) {
                    sum5 += p;
                   
                }

            }
            Console.WriteLine("{0:F2}%", (sum1 / sum) * 100);
            Console.WriteLine("{0:F2}%", (sum2 / sum) * 100);
            Console.WriteLine("{0:F2}%", (sum3 / sum) * 100);
            Console.WriteLine("{0:F2}%", (sum4 / sum) * 100);
            Console.WriteLine("{0:F2}%", (sum5 / sum) * 100);

        }
    }
}
