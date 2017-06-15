using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if(n%2==0) {
                for (int d1 = 1; d1 <= n/2; d1 *= 2) {
                    for (int d2 = 1; d2 <= n/2; d2 *= 2) {
                        for (int d3 = 1; d3 <= n/2; d3 *= 2) {
                        for(int d4=1; d4<=n/2; d4*=2) {
                                Console.WriteLine("{0}{1}{2}{3}", d1, d2, d3, d4);
                        }
                        }

                    }
                }
            } else {
            for(int p1=1; p1<=n; p1=n/p1) {
            for (int p2=1; p2<=n; p2=n/p2) {
            for(int p3=1; p3<=n; p3=n/p3) {
            for(int p4=1; p4<=n; p4=n/p4) {
                                Console.WriteLine("{0}{1}{2}{3}", p1, p2, p3, p4);
            }
            }
            }
            }
            }
        }
    }
}
