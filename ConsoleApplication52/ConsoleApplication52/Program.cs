using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", new string('%', 2 * n));
           if(n%2==0) {
           for(int i=1; i<=n-1; i++) {
           if(i==n/2) {
                        Console.WriteLine("%{0}**{0}%", new string(' ', (n * 2 - 4)/2));
           } else {
                        Console.WriteLine("%{0}%", new string(' ', n * 2 - 2));
           }
           }
           } else {
           for(int k=1; k<=n; k++) {
           if(k==n/2+1) {
                        Console.WriteLine("%{0}**{0}%", new string(' ', (n * 2 - 4) / 2));
                    } else {
                        Console.WriteLine("%{0}%", new string(' ', n * 2 - 2));
                    }
           }
            }
            Console.WriteLine("{0}", new string('%', 2 * n));


        }
    }
}
