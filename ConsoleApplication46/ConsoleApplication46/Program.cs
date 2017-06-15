using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++) {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', 2 * n + 3 - 2 * i - 2));
            } for(int k=0; k<n/3; k++) {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + k), new string('*', n - 2 * k));
            } for(int p=1; p<=n; p++) {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', p), new string('*', 2 * n + 3 - 2 - 2 * p));
            }
      }
    }
}
