using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;

                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum=" + leftSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff=" + Math.Abs(leftSum - rightSum));

            }




        }
    }
}
