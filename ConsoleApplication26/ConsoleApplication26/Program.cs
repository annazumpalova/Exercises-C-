﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= n; d1++)
            {
                for (int d2 = 1; d2 <= n; d2++)
                {
                    for (var l1 = 'a'; l1 < 'a' + 1; l1++)
                    {
                        for (var l2 = 'a'; l2 < 'a' + 1; l2++)
                        {
                            for (int d3 = Math.Max(d1, d2); d3 < n; d3++)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}", d1, d2, l1, l2, d3);
                            }
                        }
                    }
                }
            }

        }
    }
}
