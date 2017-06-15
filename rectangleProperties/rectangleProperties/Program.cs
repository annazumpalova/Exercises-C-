using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)

            {
                bool primeNumber = true;

                for (int k = 2; k <= Math.Sqrt(i); k++)

                {

                    if (i % 2 == 0)

                    {

                        primeNumber = false;

                        continue;

                    }

                }

                Console.WriteLine($"{i} -> {primeNumber}");

            }



        }
    }
}
    

