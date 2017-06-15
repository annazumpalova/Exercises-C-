using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowLenght = 2 * n - 1;
            int cols = 2 * (n - 2) + 1;
            int row = n - 1;
            int emptySpace = 1;
            Console.WriteLine(@"{0}\{1}/{0}", new string('*', n - 2), new string(' ', emptySpace));
            int emptySpacetwo = n - 2;
            Console.WriteLine(@"{0}\{1}/{0}", new string(' ', emptySpacetwo), new string (' ', emptySpace));
            Console.WriteLine(@"{0}\{1}/{0}", new string('*', n - 2), new string(' ', emptySpace));
            char a = '@';
            int emptySpacethree = n - 1;
            Console.WriteLine("{0}{1}{0}", new string(' ', emptySpacethree), a);
            Console.WriteLine(@"{0}/{1}\{0}", new string('*', n - 2), new string(' ', emptySpace));
            Console.WriteLine(@"{0}/{1}\{0}", new string(' ', emptySpacetwo), new string(' ', emptySpace));
            Console.WriteLine(@"{0}/{1}\{0}", new string('*', n - 2), new string(' ', emptySpace));




        }
    }
}
