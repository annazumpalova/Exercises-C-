using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
            Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).
            ToList();
            var line = Console.ReadLine();
            while(line!="end")
            {
                var newline=line.Split(' ').ToList();
                string command = newline[0];
                switch(command)
                {
                    case "reverse":
                        Reverse(newline, numbers);
                        break;
                    case "sort":
                        ExecuteSort(newline, numbers);
                        break;
                        case "rollLeft":
                        ExecuteRollLeft(newline, numbers);
                        break;
                    case "rollRight":
                        ExecuteRollRight(newline, numbers);
                        break;
                }

                line = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static void ExecuteSort(List<string> newline, List<string> numbers)
        {
            int startIndex = int.Parse(newline[2]);
            int count = int.Parse(newline[4]);
            if (count < 0 || startIndex<0 || startIndex>=numbers.Count|| startIndex+count>numbers.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            numbers.Sort(startIndex, count, StringComparer.InvariantCulture);

        }

        private static void ExecuteRollRight(List<string> newline,List<string>numbers)
        {
            int count = int.Parse(newline[1])%numbers.Count;
            if(count<0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            for(int i=0;i<count;i++)
            {
                string lastElement = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);

            }
        }

        private static void ExecuteRollLeft(List<string> newline, List<string>numbers)
        {
            int count = int.Parse(newline[1])%numbers.Count;
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                string firstElement = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstElement);
            }
        }

        private static void Reverse(List<string> newline, List<string> numbers)
        {
            int startIndex = int.Parse(newline[2]);
            int count = int.Parse(newline[4]);
            if (count < 0 || startIndex < 0 || startIndex >= numbers.Count || startIndex + count > numbers.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            numbers.Reverse(startIndex, count);
        }
    }
}
