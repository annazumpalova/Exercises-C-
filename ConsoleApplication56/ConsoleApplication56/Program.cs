using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();
            var den = Console.ReadLine();
            var obshtocvetq = rozi + laleta + hrizantemi;
            if (sezon == "Spring") {
                if (den == "Y")
                {
                    var cena = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;
                    var praznichenden = cena + cena * 0.15;
                    if (laleta > 7)
                    {
                        var novacena = praznichenden - praznichenden * 0.05;
                        if (obshtocvetq > 20)
                        {
                            var cenata = novacena - novacena * 0.2;
                            Console.WriteLine("{0:F2}", cenata + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", novacena + 2);
                        }
                    }
                    else
                    {
                        if (obshtocvetq > 20)
                        {
                            var cenata = praznichenden - praznichenden * 0.2;
                            Console.WriteLine("{0:F2}", cenata + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", praznichenden + 2);
                        }
                    }
                } else if (den == "N") {
                    var cena = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;
                    Console.WriteLine("{0:F2}", cena + 2);

                }
            } else if (sezon == "Summer") {
                var cena = hrizantemi * 2 + rozi * 4.10 + laleta * 2.50;
                if (den == "Y")
                {
                    var praznichenden = cena + cena * 0.15;
                    if (obshtocvetq > 20) {
                        var novacena = praznichenden - praznichenden * 0.2;
                        Console.WriteLine("{0:F2}", novacena + 2);
                    } else {
                        Console.WriteLine("{0:F2}", praznichenden + 2);
                    }
                } else if (den == "N") {
                    Console.WriteLine("{0:F2}", cena + 2);
                }
            } else if (sezon == "Autumn") {
                var cena = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                if (den == "Y") {
                    var praznichenden = cena + cena * 0.15;
                    if (obshtocvetq > 20) {
                        var novacena = praznichenden - praznichenden * 0.2;
                        Console.WriteLine("{0:F2}", novacena + 2);
                    } else {
                        Console.WriteLine("{0:F2}", praznichenden + 2);
                    }
                     
                    }
                else if (den == "N")
                {
                    Console.WriteLine("{0:F2}", cena + 2);
                }
            } else if(sezon=="Winter") {
                if (den == "Y")
                {
                    var cena = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                    var praznichenden = cena + cena * 0.15;
                    if (rozi>=10)
                    {
                        var novacena = praznichenden - praznichenden * 0.1;
                        if (obshtocvetq > 20)
                        {
                            var cenata = novacena - novacena * 0.2;
                            Console.WriteLine("{0:F2}", cenata + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", novacena + 2);
                        }
                    }
                    else
                    {
                        if (obshtocvetq > 20)
                        {
                            var cenata = praznichenden - praznichenden * 0.2;
                            Console.WriteLine("{0:F2}", cenata + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", praznichenden + 2);
                        }
                    }
                }
                else if (den == "N")
                {
                    var cena = hrizantemi * 3.75 + rozi * 4.50 + laleta * 4.15;
                    if (rozi >= 10)
                    {
                        var novacena = cena - cena * 0.1;
                        if (obshtocvetq > 20)
                        {
                            var drugacena = novacena - novacena * 0.2;
                            Console.WriteLine("{0:F2}", drugacena + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", novacena + 2);
                        }
                    } else {
                        if (obshtocvetq > 20)
                        {
                            var drugacena = cena- cena * 0.2;
                            Console.WriteLine("{0:F2}", drugacena + 2);
                        }
                        else
                        {
                            Console.WriteLine("{0:F2}", cena + 2);
                        }
                    }

                }
            }
        }
    }
}
