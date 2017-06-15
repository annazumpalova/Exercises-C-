using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
           char b =char.Parse(Console.ReadLine());
            char c =char.Parse( Console.ReadLine());
            int count = 0;
            
            for( char i=a; i<= b; i++) {
            for(char k=a;k<=b; k++ ) {
            for(char p=a;p<=b; p++) {
                       
                        if (i==c || k==c || p==c) {
                            continue;
                            
                        }
                        count++;
                        Console.Write("{0}{1}{2} ", i, k, p);
                       

                    }
            }
                    
            } Console.Write("{0}", count);

            }
        }
    }

