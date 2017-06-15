using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJunePart2
{
   public class SoftUniWater
    {
        public static void Main()
        {
            double totalAmountWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double capacity = double.Parse(Console.ReadLine());
            double numberOfbottles = 0;
            bool filledBottles = false;
            List<long> indexes = new List<long>();
            double littersNeeded = 0;

            if(totalAmountWater%2!=0)
            {
            for(int i=bottles.Length-1; i>=0; i--)
            {
            if(bottles[i]<=capacity && totalAmountWater>0)
            {
            if(totalAmountWater<capacity-bottles[i])
            {
                            bottles[i] += totalAmountWater;
                            break;
            }
                        totalAmountWater -= capacity - bottles[i];
                        bottles[i] = capacity - bottles[i];
            }

            if(bottles[0]==capacity && totalAmountWater>0)
            {
                        Console.WriteLine("Enough water!");
                        Console.WriteLine("Water left: {0}l.", totalAmountWater);
                        filledBottles = true;

            }
            }

            if(!filledBottles)
            {
            for(int i=bottles.Length-1; i>=0; i--)
            {
            if(bottles[i]<capacity)
            {
                            numberOfbottles++;
                            littersNeeded += (capacity - bottles[i]);
                            indexes.Add(i);
            } 
            if(i==0)
            {
                            Console.WriteLine("We need more water!");
                            Console.WriteLine("Bottles left: {0}", numberOfbottles);
                            string joined = string.Join<long>(", ", indexes);
                            Console.WriteLine("With indexes: "+ joined);
                            Console.WriteLine("We need {0} more liters!", littersNeeded);
            }
            }
            }
            }

            if (totalAmountWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    if (bottles[i] <= capacity && totalAmountWater > 0)
                    {
                        if (totalAmountWater < capacity - bottles[i])
                        {
                            bottles[i] += totalAmountWater;
                            break;
                        }
                        totalAmountWater -= capacity - bottles[i];
                        bottles[i] = capacity - bottles[i];
                    }
                
                if (bottles[bottles.Length - 1] == capacity && totalAmountWater > 0)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", totalAmountWater);
                    filledBottles = true;
                }
            }

            if(!filledBottles)
            {
            for(int i=0; i<bottles.Length; i++)
            {
            if(bottles[i]<capacity)
            {
                            numberOfbottles++;
                            littersNeeded += (capacity - bottles[i]);
                            indexes.Add(i);
            }
            if(i==bottles.Length-1)
            {
                            Console.WriteLine("We need more water!");
                            Console.WriteLine("Bottles left: {0}", numberOfbottles);
                            string joined = string.Join<long>(", ", indexes);
                            Console.WriteLine("With indexes: " + joined);
                            Console.WriteLine("We need {0} more liters!", littersNeeded);
                       }
            }
            }
            }
        }
    }
}
