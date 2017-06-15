using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var kategoria = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());
            double normalTick = 249.99;
            double vipTick = 499.99;
            if (people > 1 && people < 4)
            {
                double travel = money * 0.75;
                double n = money - travel;
                if (kategoria == "Normal")
                {
                    if (n >= normalTick * people)
                    {
                        double razlika = n - normalTick * people;
                        Console.WriteLine("Yes, you have {0} leva left", razlika);
                    }
                    else if (n < normalTick * people)
                    {
                        double nedostiga = normalTick * people - n;
                        Console.WriteLine("Not enought money! You needed {0} leva.", nedostiga);
                    }
                }
                else if (kategoria == "VIP")
                {
                    if (n >= vipTick * people)
                    {
                        double razlika1 = n - vipTick * people;
                        Console.WriteLine("Yes, you have {0} leva left", razlika1);
                    }
                    else if (n < vipTick * people)
                    {
                        double nedostig1 = vipTick * people - n;
                        Console.WriteLine("Not enought money! You needed {0} leva", nedostig1);
                    }

                }

            }
            else if (people > 5 && people < 9)
            {
                double travel1 = money * 0.6;
                double m = money - travel1;
                if (kategoria == "Normal")
                {
                    if (m >= normalTick * people)
                    {
                        double razlika2 = m - normalTick * people;
                        Console.WriteLine("Yes, you have {0} leva left", razlika2);
                    }
                    else if (m < normalTick * people)
                    {
                        double nedostig2 = normalTick * people - m;
                        Console.WriteLine("Not enought money! You needed {0} leva.", nedostig2);
                    }

                }
                else if (kategoria == "VIP")
                {
                    if (m >= vipTick * people)
                    {
                        double razlika3 = m - vipTick * people;
                        Console.WriteLine("Yes, you have {0} leva left", razlika3);

                    }
                    else if (m < vipTick * people)
                    {
                        double nedostig3 = vipTick * people - m;
                        Console.WriteLine("Not enought money! You needed {0} leva.", nedostig3);

                    }
                }

            } else if(people>10 && people<24) {
                double travel2 = money * 0.5;
                double p = money - travel2;
                if(kategoria=="Normal"){
                if(p>=normalTick*people) {
                        double razlika3 = p - normalTick * people;
                        Console.WriteLine("Yes, you have {0} leva left", razlika3);
                    }
                    else if (p < normalTick * people)
                    {
                        double nedostig3 = normalTick * people - p;
                        Console.WriteLine("Not enought money! You needed {0} leva.", nedostig3);
                    }

                }
                else if (kategoria == "VIP")
                {
                    if (p >= vipTick * people)
                    {
                        double razlika4 = p - vipTick * people;
                        Console.WriteLine("Yes, you have {0} leva left", razlika4);

                    }
                    else if (p < vipTick * people)
                    {
                        double nedostig4 = vipTick * people - p;
                        Console.WriteLine("Not enought money! You needed {0} leva.", nedostig4);

                    }
                }
            }
            }
        }
    }


