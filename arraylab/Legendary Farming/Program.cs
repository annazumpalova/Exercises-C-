using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, long> trashStorage = new Dictionary<string, long>();
            Dictionary<string, long> valuableStorage = new Dictionary<string, long>
            {
                { "fragments", 0 },
                { "shards", 0 },
                { "motes", 0 }
            };
            List<string> input;
            bool weaponObtained = false;
            while (!weaponObtained)
            {
                input = Console.ReadLine()
                       .ToLower()
                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .ToList();

                long quantity = 0;
                string material = "";

                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(input[i]);
                    }
                    else
                    {
                        material = input[i];
                        //If both mat and quan are filled
                        //Check if valuable
                        if (CheckMaterial(material))
                        {
                            //Check if valuableStorage contains it
                            if (!valuableStorage.ContainsKey(material))
                            {
                                valuableStorage.Add(material, quantity);
                            }
                            else
                            {
                                valuableStorage[material] += quantity;
                            }

                            //Check if quantity enough
                            if (valuableStorage[material] >= 250)
                            {
                                valuableStorage[material] -= 250;
                                string weaponWon = ReturnWeapon(material);
                                Console.WriteLine($"{weaponWon} obtained!");
                                weaponObtained = true;
                                break;
                            }
                        }
                        //Else if not valuable
                        else
                        {
                            //If contain trash item
                            if (!trashStorage.ContainsKey(material))
                            {
                                trashStorage.Add(material, quantity);
                            }
                            else
                            {
                                trashStorage[material] += quantity;
                            }
                        }
                    }
                }
            }

            foreach (var matQuan in valuableStorage.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{matQuan.Key}: {matQuan.Value}");
            }

            foreach (var matQuan in trashStorage.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{matQuan.Key}: {matQuan.Value}");
            }
        }

        public static bool CheckMaterial(string material)
        {
            if (material.Equals("shards") || material.Equals("fragments") || material.Equals("motes"))
            {
                return true;
            }
            return false;
        }

        public static string ReturnWeapon(string material)
        {

            if (material.Equals("shards"))
            {
                return "Shadowmourne";
            }
            else if (material.Equals("fragments"))
            {
                return "Valanyr";
            }
            else if (material.Equals("motes"))
            {
                return "Dragonwrath";
            }

            return "";
        }
    }
}