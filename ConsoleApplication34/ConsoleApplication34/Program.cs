using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxaap
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonone = int.Parse(Console.ReadLine());
            var pokemontwo = int.Parse(Console.ReadLine());
            var broi = int.Parse(Console.ReadLine());
            for(int d1=1; d1<=pokemonone; d1++) {
            for(int d2=1; d2<=pokemontwo; d2++) 
            { for (int broidve =1; broidve <= Math.Max(d1, d2); broidve++)
                    {
                        if (broidve <= broi)
                        {
                            Console.Write("({0} <-> {1}) ", d1, d2);
                            break;
                        }
                    }
            }
            }
        }
    }

    }


       