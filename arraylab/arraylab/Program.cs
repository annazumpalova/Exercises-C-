using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylab
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var newArray = new string[input.Length - 1];
            string line = Console.ReadLine();
            while (line!="end") {
                string[] commandTockens = line.Split(' ');
                string commandAction = commandTockens[0];
                switch(commandAction)
                 {
                    case "swap":
                        Swap(input, commandTockens[1], commandTockens[2]);
                        break;
                    case "multiply":
                    Multiply(input, commandTockens[1], commandTockens[2]);
                        break;
                    case "decrease":
                        Decrease(input);
                        break;

                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", input));
        }

        static void Decrease(long[] input)
        {
           for(int i=0; i<input.Length; i++)
           {
                input[i] = input[i] + 1;
           }
        }

        static void Multiply(long[] input, string first, string second)
        {
            int firstIndex = int.Parse(first);
            int secondIndex = int.Parse(second);
            input[firstIndex] = input[firstIndex] * input[secondIndex];
        }

        static void Swap(long[]input, string first, string second)
        {
            int firstIndex = int.Parse(first);
            int secondIndex = int.Parse(second);
            var oldValue = input[int.Parse(first)];
            input[int.Parse(first)] = input[secondIndex];
            input[secondIndex] = oldValue;
        }
    }
}
