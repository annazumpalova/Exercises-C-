using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber();
        }
        static void PrimeNumber()
         {
            int number = int.Parse(Console.ReadLine());
            bool prime = true;
            for(int i=2; i<=Math.Sqrt(number); i++)
             {
             if(number%i==0)
             {
                    prime = false;
                    continue;
             }
                Console.WriteLine(prime);

            }

        }
    }
}
