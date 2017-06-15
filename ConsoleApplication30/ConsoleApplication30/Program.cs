using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for(int i=1; i<=n; i++) {
                var num = int.Parse(Console.ReadLine());
                for (int p = 1; p <= n; p += 3)
                {
                    sum1 = sum1 + num;

                    for (int m = 2; m <= n; m += 3)
                    {
                        sum2 = sum2 + num;

                        for (int k = 3; k <= n; k += 3)
                        {
                            sum3 = sum3 + num;

                        }
                    }
                }
            } Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
