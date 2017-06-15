using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = 2 * (n - 2) + 1;
            int rowsLenght = 2 * n - 1;
            int space = 1;
            int asterix = n - 2;
            for (int i=0; i<n-2; i++) {
            if(i%2==1)
                {
                    Console.WriteLine(@"{0}\{1}/{0}", new string('-', asterix), new string(' ', space));

                } else {
                    Console.WriteLine(@"{0}\{1}/{0}", new string('*', asterix), new string(' ', space));
                          }
           }            Console.WriteLine("{0}@{0}", new string(' ', asterix + 1));
           for( int j=0;j<n-2;j++) {
           if(j%2==1) {
                    Console.WriteLine(@"{0}/{1}\{0}", new string('-', asterix), new string(' ', space));

                } else {
                    Console.WriteLine(@"{0}/{1}\{0}", new string('*', asterix), new string(' ', space));

                }
           }
        }

        }
            
           

        }
    


