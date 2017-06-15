using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StringLAb
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var number = BigInteger.Parse(input[1]);
            var numberBase = int.Parse(input[0]);

            var result = ConvertFromDecimalToBaseN(number, numberBase);
            Console.WriteLine(result);
            
        }

        static BigInteger ConvertFromDecimalToBaseN(BigInteger number, int numberBase)
        {
            var numberAsString = number.ToString();
            var sum = new BigInteger(0);
            for(int i=0; i<numberAsString.Length;i++)
            {
                var num = int.Parse(numberAsString[numberAsString.Length-1-i].ToString());
                var result= num *BigInteger.Pow(numberBase, i);
                sum += result;
            }
            return sum;
        }
    }
}
