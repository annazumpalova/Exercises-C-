using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ArraysLab
{
    public class Program
    {
       public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0; i<numbers.Length; i++)
            {
            if(numbers[i]<numbers[i+1])
            {
            if(numbers[i+1]-numbers[i]==difference)
            {
                        count++;
            } else 
            {
                        break;
            }
        
            } else if(numbers[i]>numbers[i+1])
            {
            if(numbers[i]-numbers[i+1]==difference)
            {
                        count++;
            } else {
                        break;
            }
            }
            } Console.WriteLine(count);
            
                       
           

        }

        }
    }

    