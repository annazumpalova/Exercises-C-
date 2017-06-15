using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = (n + 1) / 2;
            int rowLenght = n;
            int asterix = 2;
            for (int i=0; i<rows-1; i++) {
            if(n%2==0) {
                    
                    Console.WriteLine("{0}{1}{0}", new string('_', n - 2-i), new string('*', asterix+ 2*i));
            } else {
                    Console.WriteLine("{0}{1}{0}", new string('_', n - 1-i), new string('*', (asterix - 1)+2*i));
            } 
           
            }
            
        }
         
           

                       
            }
        }
    

