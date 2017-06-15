using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMagicLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = Console.ReadLine().Split(' ').ToList();
            char[] firstWord = sc[0].ToCharArray();
            char[] secondWord = sc[1].ToCharArray();

            var exchangable = new Dictionary<char, char>();
            bool result = true;

            if(firstWord.Length==secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                if(exchangable.ContainsKey(firstWord[i]))
                {
                if(firstWord[i]!=secondWord[i])
                {
                            result = false;
                            break;
                }
                else {
                            exchangable.Add(firstWord[i], secondWord[i]);
                }
                }
                }
            } else {
                result = false;
            }

            Console.WriteLine();
        }
    }
}
