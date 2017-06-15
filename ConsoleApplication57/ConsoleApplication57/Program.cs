using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double top = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double topcount = 0;
            double acount = 0;
            double bcount = 0;
            double ccount = 0;
            for(double i=1; i<=n;i++) {
                double num = double.Parse(Console.ReadLine());
                if(num>=5.00) {
                    top++;
                    topcount += num;
                } else if(num>=4.00 && num<=4.99) {
                    a++;
                    acount += num;
                } else if(num>=3.00 && num<=3.99) {
                    b++;
                    bcount += num;
                }else if(num<3.00) {
                    c++;
                    ccount += num;
                }

                
            }
            double average = (topcount + acount + bcount + ccount) / n;
            Console.WriteLine("Top students: {0:F2}%", top / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", a / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", b / n * 100);
            Console.WriteLine("Fail: {0:F2}%", c / n * 100);
            Console.WriteLine("Average: {0:F2}", average);

        }
    }
}
