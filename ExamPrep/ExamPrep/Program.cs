using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        public static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            long numberOfrunner = long.Parse(Console.ReadLine());
            int numberOflaps = int.Parse(Console.ReadLine());
            long lengthOftrack = long.Parse(Console.ReadLine());
            int caparityOftrack = int.Parse(Console.ReadLine());
            decimal moneyPerkilo = decimal.Parse(Console.ReadLine());

            long maxRunners = caparityOftrack * day;
            if(numberOfrunner>maxRunners)
            {
                numberOfrunner = maxRunners;
            }
            long totalMeter = numberOfrunner * numberOflaps*lengthOftrack;
            long meterInkilometer = totalMeter / 1000;
            decimal allMoneyforMarathon = moneyPerkilo * meterInkilometer;
            Console.WriteLine("Money raised: {0:F2}", allMoneyforMarathon);
        }
    }
}
