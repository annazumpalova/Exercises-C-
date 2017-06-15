using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Trim();
            var output = new SortedDictionary<string, Dictionary<string, int>>();

            while (line != "end")
            {
                string[] usersInfo = line.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                string username = usersInfo[5];
                string IP = usersInfo[1];
                int counter = 1;

                if (!output.ContainsKey(username))
                {
                    output.Add(username, new Dictionary<string, int>());
                }
                if(!output[username].ContainsKey(IP))
                {
                    output[username].Add(IP, counter);
                }
                else 
                {
                    output[username][IP]++;
                }

                line = Console.ReadLine();
            }

            foreach(var user in output)
            {
                Console.WriteLine("{0}: ", user.Key);
                foreach(var log in user.Value)
                {
                    var thing = log.Key;
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    } else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}