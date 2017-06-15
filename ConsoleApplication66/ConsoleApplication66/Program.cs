using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSeqInc_13._05._2016
{
    class Program
    {
        static void Main(string[] args)
        {
          



                int n = int.Parse(Console.ReadLine());
                bool prime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0 && n==0 && n==1)
                    {
                        prime = false;
                    }
                }
                Console.WriteLine(prime);
            }
        }
    }
