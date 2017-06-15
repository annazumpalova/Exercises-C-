using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n + 1;
            char pipe = '|';

            for (int currow = 0; currow < rows; currow++)
            {
                string dashString = new string(' ', n - currow);
                string asterix = new string('*', currow);
                Console.WriteLine("{0}{1}{2}{1}{0}", dashString, asterix, pipe);
                 

            } Console.WriteLine();                
                       
                        }
    }
}
