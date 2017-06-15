using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersJune12
{
    public class NumbersJune12
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newNumbers = new List<int>();
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double averageNumbers = sum / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNumbers)
                {
                    newNumbers.Add(numbers[i]);
                }
            }
            if (newNumbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                newNumbers.Sort();
                newNumbers.Reverse();
                if (newNumbers.Count > 5)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("{0} ", newNumbers[j]);
                    }
                }
                else
                {

                    foreach (var item in newNumbers)
                    {
                        Console.Write("{0} ", item);
                    }
                }
            }
            }
        }
    }


