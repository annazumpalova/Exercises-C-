using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String[] input1 = Console.ReadLine().Split(' ');
            String[] input2 = Console.ReadLine().Split(' ');
           long[] beehives=new long[input1.Length];
            List<long> hornets = new List<long>();
            for (int i = 0; i < beehives.Length; i++)
            {
                beehives[i] =int.Parse(input1[i]);
            }
            for (int i = 0; i < input2.Length; i++)
            {
                hornets.Add(int.Parse(input2[i]));
            }
           
       long hornetsSum = hornets.Sum();
            for (int i = 0; i < beehives.Length; i++)
            {
                if (beehives[i] < hornetsSum)
                {
                    beehives[i] = 0;
                }
                else if (beehives[i] == hornetsSum)
                {
                    beehives[i] = 0;
                    hornets.RemoveAt(0);
                }
                else if (beehives[i] > hornetsSum)
                {
                    beehives[i] = beehives[i] - hornetsSum;
                    hornets.RemoveAt(0);
                }
                hornetsSum = hornets.Sum();
            }
          
            bool aliveBehives = beehives.All(x => x == 0);
            if (!aliveBehives)
            {
                for (int i = 0; i < beehives.Length; i++)
                {
                    if (beehives[i] != 0)
                    {
                        Console.Write(beehives[i] + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
        }
    }
}