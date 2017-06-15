using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var broi = int.Parse(Console.ReadLine());
            
            for(int d1=1; d1<=n; d1++) {
                    for (int d2 = 1; d2 <= m; d2++)
                    {
                    for (int i = 1; i <= broi; i++)
                    {
                        if (broi)
                        {
                            break;
                        }
                        Console.Write("({0} <-> {1}) ", d1, d2);
                    }
                    }    }
            }
            
        }
    }

