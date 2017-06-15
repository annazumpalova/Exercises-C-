using System;
using System.Collections.Generic;
using System.Linq;


namespace PhoneBook
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine()
            .Split(' ')
            .ToArray();

            var phoneBook = new Dictionary<string, string>();

            while(text[0] !="END")
            {
                if (text[0] == "A")
                {
                    phoneBook[text[1]] = text[2];
                }

                else if(text[0]=="S")
                {
                if(phoneBook.ContainsKey(text[1]))
                {
                        Console.WriteLine($"{text[1]} -> {phoneBook[text[1]]}");
                }
                else {
                        Console.WriteLine($"Contact {text[1]} does not exist.");
                }
                     text = Console.ReadLine()
               .Split(' ')
               .ToArray();
                }

                
            }

        }
    }
}
