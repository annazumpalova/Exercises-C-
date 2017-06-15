using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication69
{
    public class Program
    {


        public static void Main()
        {
            var firstPoints = Console.ReadLine().Split(' ');
            var secondPoints = Console.ReadLine().Split(' ');

            var firstCircle = new Point
            {
                X = double.Parse(firstPoints[0]),
                Y = double.Parse(firstPoints[1]),
                R = double.Parse(firstPoints[2]),
            };

            var secondCircle = new Point
            {
                X = double.Parse(secondPoints[0]),
                Y = double.Parse(secondPoints[1]),
                R = double.Parse(secondPoints[2]),

            };

            double distance = CalculateDistance(firstCircle, secondCircle);
            double radiusesSum = firstCircle.R + secondCircle.R;

            if(distance<=radiusesSum)
            {
                Console.WriteLine("Yes");
            } 
            else 
            {
                Console.WriteLine("No");
            }
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - firstPoint.Y;
            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);
            return Math.Sqrt(powX + powY);
        }

        
    }
}
