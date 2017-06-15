using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexEx
{
   public class Email
    {
       public static void Main()
        {

            var input = Console.ReadLine();
            string pattern = @"([\w-.]+\@[\w]+)(\.[\w]+)+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach(Match match in matches)
            {
                Console.WriteLine(match.ToString());
            }



        }
    }
}
