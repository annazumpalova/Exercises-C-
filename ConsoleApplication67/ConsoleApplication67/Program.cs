using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication67
{
    public class Program
    {
       public static void Main()
        {

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var powerNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var a = powerNumbers[0];
            var b = powerNumbers[1];
            int pos = 0;
            int sumNumbers = 0;
            int sumList = 0;
          
            for(int i=0; i<numbers.Count; i++)
            {
                sumNumbers += numbers[i];
            }

            while(pos<numbers.Count)
            {
            if(numbers[pos]== a)
            {
            for(int k=numbers[pos-b]; k<=numbers[pos+b]; k++)
            {
                        sumList += numbers[k];
            }
                    pos++;
            } else {
                    pos++; 
            } 
              
            }
            int result = sumNumbers - sumList;
            Console.WriteLine(result);
            }
    }
}
