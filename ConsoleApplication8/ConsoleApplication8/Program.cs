using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = (n + 1) / 2;
            int row = n;
            int asterix=1 ;
            for (int i = 0; i <rows ; i++)
            {
                int emphtySpace = (n -1)/2;
                if(i%2==1) {
                    Console.WriteLine("{0}{1}{0}", new string(' ', emphtySpace), new string('*', asterix));
                } else {
                    Console.WriteLine("{0}{1}{0}", new string(' ', emphtySpace), new string('*', asterix+1));
                }
            }
        }
    }
}
