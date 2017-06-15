using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication68
{
   public class Program
    {
       public static void Main()
      {
            var cardsPower = GetCardPower();
            var cardsTypes = GetCardTypes();

            var cards = new Dictionary<string, HashSet<int>>();

            var line = Console.ReadLine();
            while (line != "JOKER")
            {
                var tokens = line.Split(':');
                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach(var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);
                    var sum = cardsPower[cardPower] * cardsTypes[cardType];

                    if(!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }
                line = Console.ReadLine();
            }
            foreach(var pair in cards)
            {
                var name = pair.Key;
                var sumCard = pair.Value.Sum();

                Console.WriteLine($"{name}: {sumCard}");
            }
        }
        
        private static Dictionary<string, int> GetCardPower()
        {
            var power = new Dictionary<string, int>();
            for(int i=2; i<=10; i++)
            {
                power[i.ToString()] = i;
            }

            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14;

            return power;

        }
        private static Dictionary<string, int> GetCardTypes()
        {
            var cardTypes = new Dictionary<string, int>();
            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            return cardTypes;

        }
    }
}
