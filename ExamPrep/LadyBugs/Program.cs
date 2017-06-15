using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).Where(a=>a>=0 && a <fieldSize).ToList();
            var ladybugs = new int[fieldSize];

            for(int i=0; i<ladybugIndexes.Count; i++)
            {
            if(ladybugIndexes[i]>=fieldSize|| ladybugIndexes[i]<0)
            {
                    ladybugIndexes.RemoveAt(i);
                    i--;
            }
               
            }
            var line = Console.ReadLine();

            while(line!="end")
            {
                var tokens = line.Split();
                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if(ladybugIndex<0 || ladybugIndex>=ladybugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }

                if(ladybugs[ladybugIndex]==0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadybig(ladybugs, ladybugIndex, flyLength, direction);
                line = Console.ReadLine();
                Console.WriteLine(string.Join(" ", ladybugs));
            }
           
        }

        private static void MoveLadybig(int[] ladybugs, int ladybugIndex, int flyLength, string direction)
        {
            ladybugs[ladybugIndex] = 0;
            var lefrArrayorFoundPlace = false;

            while(!lefrArrayorFoundPlace)
            {
                switch (direction)
                {
                    case "left":
                        ladybugIndex -= flyLength;
                        break;
                    case "right":
                        ladybugIndex += flyLength;
                        break;
                }
            if(ladybugs[ladybugIndex]==1)
            {
                    continue;
            }

                if (ladybugs[ladybugIndex] == 0)
                {
                    ladybugs[ladybugIndex] = 1;
                    lefrArrayorFoundPlace = true;
                    continue;
                }
            }
        }
    }
}
