using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondHornet
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            Dictionary<string, string> broadcasts = new Dictionary<string, string>();
            Dictionary<string, string> messeges = new Dictionary<string, string>();

            while (line != "Hornet is Green")
            {

                var newLine = line.Split(' ').ToList();

                if (newLine.Count < 3)
                {
                    line = Console.ReadLine();
                    return;
                }
                string firstQuery = newLine[0];

                string secondQuery = newLine[2];

                bool messageFirstDigitsOnly = firstQuery.All(char.IsDigit);
                bool messageSecondLettersAndDigits = secondQuery.All(char.IsLetterOrDigit);
                bool broadchastFirstletters = firstQuery.Any(char.IsLetter);
                bool broadchastFirstSymbols = firstQuery.Any(char.IsSymbol);
                bool broadchastSecond = secondQuery.All(char.IsLetterOrDigit);

                if(messageFirstDigitsOnly==true && messageSecondLettersAndDigits==true)
                {
                    messeges.Add(firstQuery, secondQuery);
                } 
                else if(broadchastFirstletters==true || broadchastFirstSymbols==true && broadchastSecond==true)
                {
                    broadcasts.Add(firstQuery, secondQuery);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if(broadcasts.Count==0)
            {
                Console.WriteLine("None");
            }
            foreach(KeyValuePair<string, string> item in broadcasts)
            {
                var newitem=item.Value.ToCharArray();
                for(int i=0; i<newitem.Length; i++)
                {
               
                }
                Console.WriteLine($"{item.Value} -> {item.Key}");
            }
            Console.WriteLine("Messages:");
            if (messeges.Count == 0)
            {
                Console.WriteLine("None");
            }

            foreach(var itemtwo in messeges)
            {
                var newitem = itemtwo.Key.Reverse();
                Console.WriteLine($"{newitem} -> {itemtwo.Value}");
            }
        }
    }
}
