using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', ));
            for(int i=0; i<n; i++) {
                Console.WriteLine(@"{0}//{1}\\{0}", new string('.', n - i), new string('_', 3 * n - 4 - 2 * (n - i)));

            } Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', 3 * n - 9));
            

            
        
            
            }
        }
    }

