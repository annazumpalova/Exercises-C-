using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++) {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', (3 * n -2*i - 2) / 2), new string(' ', 2 * i)); 
            } Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', 3 * n - 2 * (n / 2)));
            for(int p=0; p<n*2; p++) {
               
               var cherta = 3 * n - 2 - 2*(n / 2);

                Console.WriteLine(@"{0}|{1}|{0}", new string('.', n / 2), new string('\\',cherta));
            } for(int k=0; k<n/2; k++) {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', n / 2 - k), new string('*', 3 * n - 2 - 2 * (n / 2 - k)));
            }
        } 
    }
}
