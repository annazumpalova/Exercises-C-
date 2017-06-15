using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        char symbolFirst = (char)('a' + i1);
                        char symbolSecond = (char)('a' + i2);
                        char symbolThird = (char)('a' + i3);
                        Console.WriteLine("{0}{1}{2}", symbolFirst, symbolSecond, symbolThird);
                    }
                }


            }
        }
    }
}
