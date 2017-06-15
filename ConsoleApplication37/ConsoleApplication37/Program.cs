using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n * 3));
            for(int i=0; i<n-1; i++) {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i), new string('.', 5 * n - 2 - 2 * i));
            } Console.WriteLine("{0}", new string('*', 5 * n));
            for(int p=0; p<n*2; p++) {
                Console.WriteLine("{0}*{1}*{0}", new string('.', p + 1), new string('.', 5 * n - 2 - 2 * p));
            }
        }
    }
}
