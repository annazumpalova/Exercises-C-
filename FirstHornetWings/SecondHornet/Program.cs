using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHornet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            Dictionary<string, string> broadcasts = new Dictionary<string, string>();
            Dictionary<string, string> messeges = new Dictionary<string, string>();

            while (line != "Hornet is Green")
            {

                var newLine = line.Split(' ').ToList();


                string firstQuery = newLine[0];

                string secondQuery = newLine[2];

                bool digitsOnly = firstQuery.All(char.IsDigit);
                bool symblsOnly = firstQuery.All(char.IsSymbol);
                bool wordsOnly = firstQuery.All(char.IsLetterOrDigit);

                if (digitsOnly == true && symblsOnly == false && wordsOnly == false)
                {
                    broadcasts.Add(firstQuery, secondQuery);
                }
                else if (symblsOnly == true && wordsOnly == false)
                {
                    messeges.Add(secondQuery, firstQuery);
                }
                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (messeges.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var item in messeges)
            {
                Console.WriteLine($"{item.Value} -> {item.Key}");
            }
            Console.WriteLine("Messages:");

            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }

            foreach (var itemtwo in broadcasts)
            {
                var reversedNumber = itemtwo.Key.Reverse();
                Console.WriteLine($"{reversedNumber} -> {itemtwo.Value}");
            }
        }
    }
}
