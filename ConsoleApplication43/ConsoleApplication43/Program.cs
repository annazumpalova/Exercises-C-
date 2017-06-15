using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cherta = 1;
            var naklonena = 1;
            for (int i=1;i<=n/2; i++) {
                
                Console.WriteLine("{0}", new string('|', cherta));
            } for(int k=0; k<n-1; k++) {
                Console.WriteLine("{0}{1}{2}", new string('|', cherta), new string(' ', k), new string('\\', naklonena));
            } for(int p=0; p<n+2; p++) {
                Console.WriteLine("{0}{1}{2}", new string('|', cherta), new string('*', n - 1 + p), new string('\\', naklonena));
            } for(int m=0; m<n+1; m++) {
                Console.WriteLine("{0}{1}{0}", new string('|', cherta), new string('*', n * 2));
            } for(int a=0; a<n-2; a++) {
                Console.WriteLine("{0}{1}{2}", new string('|', cherta), new string('*', n * 2 - a), new string('/', naklonena));
            } Console.WriteLine("{0}", new string('-', n * 2 + 2));
        }
    }
}
