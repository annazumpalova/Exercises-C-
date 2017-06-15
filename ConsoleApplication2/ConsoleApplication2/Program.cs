using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           for( int i=1; i<=n; i++)
            {
                string buchstabe = new string('o', i);
                string spaces = new string(' ', n - i);
                Console.WriteLine(spaces);
                Console.WriteLine(buchstabe);
                Console.WriteLine(spaces);

            }
            
            
            
        }
    }
}
