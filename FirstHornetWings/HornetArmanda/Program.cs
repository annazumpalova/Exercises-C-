using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmanda
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            for(int i=0; i<number; i++)
            {
                var line = Console.ReadLine().Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            }



        }
    }
}
