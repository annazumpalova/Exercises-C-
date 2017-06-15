using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWingsFirst
{
    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var lists = new List<int>();
            var sum = hornets.Sum();


            for (int k = 0; k < beehives.Count; k++)
            {
                if (beehives[k] < sum)
                {
                    continue;
                }
                else
                {
                        var result = beehives[k] - sum;
                        lists.Add(result);
                        sum = sum - hornets[0];
                        hornets.RemoveAt(0);
                    
                }
            }
            if (lists.Count == 1)
            {
                foreach (var item in hornets)
                {
                    Console.Write($"{item} ");
                }

            }
            else if (lists.Count == 1 && beehives[beehives.Count-1]>sum)
            {
                var resultlast = beehives[beehives.Count-1] - sum;
                Console.Write(resultlast);
                
            }
            else if(lists.Count>1)
            {
                foreach (var itemone in lists)
                {
                    Console.Write($"{itemone} ");
                }
            }
        }
    }
}
