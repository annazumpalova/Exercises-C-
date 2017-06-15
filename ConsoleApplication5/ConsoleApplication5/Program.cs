using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowsLenght = (2 * n) - 1;
            int colsLenght = 2 * (n - 2) + 1;
            int row = n - 1;
            for( int currRow=0; currRow<colsLenght; currRow++ ) {
                int asterix = n - 2;
                int spacesone = 1;
                Console.WriteLine(@"{0}\[1}/{0}", new string('*', asterix), new string(' ', spacesone));
            }
        }
    }
}
