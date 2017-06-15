using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2= int.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());        
            if(symbol=='+' || symbol=='-' || symbol=='*') {
                if (symbol =='+') {
                    int result1 = n1 + n2;
                    if (result1 % 2 == 0)
                    {
                        string n = "even";
                        Console.WriteLine("{0}{1}{2}={3}-{4}", n1, symbol, n2, result1, n);
                    } else {
                        string p = "odd";
                        Console.WriteLine("{0}{1}{2}={3}-{4}", n1, symbol, n2, result1, p);
                    }

                } else if(symbol=='-') {
                    int result4 = n1 - n2;
                    if (result4 % 2 == 0)
                    {
                        string m = "even";
                        Console.WriteLine("{0}{1}{2}={3}-{4}", n1, symbol, n2, result4, m);
                    } else {
                        string r = "odd";
                        Console.WriteLine("{0}{1}{2}={3}-{4}", n1, symbol, n2, result4, r);
                    }
              } else if(symbol=='*') {
                    int result5 = n1 * n2;
                    if (result5 % 2 == 0)
                    {
                        string p = "even";
                        Console.WriteLine("{0}{1}{2}={3}-{4}", n1, symbol, n2, result5, p);
                    } else {
                        string a = "odd";
                        Console.WriteLine("{0}{1}{2}={3}-{4}", n1, symbol, n2, result5, a);
                    }
              }
            } else if(symbol=='/') {
                double result2 = n1 / n2;
                Console.WriteLine("{0}{1}{2}={3}", n1, symbol, n2, result2);
            } else if(symbol=='%') {
                int result3 = n1 % n2;
                Console.WriteLine("{0}{1}{2}={3}", n1, symbol, n2, result3);
            } else if(n2==0 || n1==0) {
                if (n1 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }else if(n2==0) {
                    Console.WriteLine("Cannot divide{0} by zero", n2);
                }
            }





        }
    }
        }
    

