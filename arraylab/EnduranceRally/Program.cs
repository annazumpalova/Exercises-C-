using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    public class Program
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var track = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach(var driver in drivers)
            {
                double fuel = driver.First();
                for(int i=0;i<track.Length; i++)
                {
                    var currentZonefuel = track[i];
                    if(checkpoints.Contains(i))
                    {
                        fuel += currentZonefuel;
                    } else 
                    {
                        fuel -= currentZonefuel;
                    }

                    if(fuel<=0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if(fuel>0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", driver, fuel);
                }
            }
        }
    }
}
