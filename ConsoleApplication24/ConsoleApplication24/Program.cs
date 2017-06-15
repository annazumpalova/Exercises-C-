using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchtickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var red = 5 * n;
            int asterix = 1;
            for (int i=0; i<n;i++) {
                int tirencanachalo = 3 * n;
                int tirencasreda = i;
                int tirencakrai = 2 * n - 2-i;
                Console.WriteLine("{0}{1}{2}{1}{3}", new string('-', tirencanachalo), new string('*', asterix),
                 new string('-', tirencasreda) ,new string('-', tirencakrai));
            } for(int p=0; p<n/2; p++) {
                int asterixnachalo = 3 * n+1;
                int tirencavsreda = n - 1;
                Console.WriteLine("{0}{1}{2}{1}",new string('*', asterixnachalo), 
                new string('-', tirencavsreda), new string('*', asterix));
            } for(int m=0; m<n/2-1; m++) {
                int tirencanach = 3 * n -m;
                int tirencasred = n - 1 + 2 *m;
                int tirencakr = n - 1 - m;
                Console.WriteLine("{0}{1}{2}{1}{3}", new string('-', tirencanach), new string('*', asterix),
                new string('-', tirencasred), new string('-', tirencakr));

           } int tirencakraenred = 3 * n + 1 - n / 2;
            if (n % 2 == 0) {
                int asterixnumber = 2 * n - 1;
                int tirencasredakraenred = n / 2;
                Console.WriteLine("{0}{1}{2}", new string('-', tirencakraenred), new string('*', asterixnumber), new string('-', tirencasredakraenred));
            } else {
                int asterixnumberone = 2 * n - 2;
                int tirencakraiposledenred = n/2+1;
                Console.WriteLine("{0}{1}{2}", new string('-', tirencakraenred), new string('*', asterixnumberone),
                 new string('-', tirencakraiposledenred));
               }
            }
            }
           
        }
    

