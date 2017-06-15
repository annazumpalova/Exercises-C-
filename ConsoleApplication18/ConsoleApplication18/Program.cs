using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count1 = 0.0;
            double count2 = 0.0;
            double count3 = 0.0;
          
            for(int i=0; i<n;i++) {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count1++;
                }
                else if (number % 3 == 0)
                {
                    count2++;
                }
                else if (number % 4 == 0)
                {
                    count3++;
                }
            
            }
            Console.WriteLine("{0:0.00}%",count1/n*100);
            Console.WriteLine("{0:0.00}%", count2/n*100);
            Console.WriteLine("{0:0.00}%", count3/n*100);
        }
    }
}
