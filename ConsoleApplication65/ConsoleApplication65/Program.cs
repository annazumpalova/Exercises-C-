using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            CenterPoint();
        }
        static void CenterPoint()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2= double.Parse(Console.ReadLine());
            double x3= double.Parse(Console.ReadLine());
            double y3= double.Parse(Console.ReadLine());
            double x4=double.Parse(Console.ReadLine());
            double y4= double.Parse(Console.ReadLine());

            double firstDistance =getDistanceBetweenTwoPoints(x1, y1, x2, y2);
            double secDistance =getDistanceBetweenTwoPoints(x3, y3, x4, x4);

            double firstDistaceToZero = GetDistanceToZero(x1, y1, 0);
            double secDistanceToZero = GetDistanceToZero(x2, y2, 0);
            double thirdDistaceToZero = GetDistanceToZero(x3, y3, 0);
            double fourthDistanceToZero = GetDistanceToZero(x4, y4, 0);

            if(firstDistance>=secDistance)
            {
            if(firstDistaceToZero>secDistanceToZero)  
            {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            } else 
             {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            } else  
            {
            if(firstDistaceToZero>secDistanceToZero)
            {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else 
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }


        }

        static double GetDistanceToZero(double x, double y, double zero)
        {
        double distance=Math.Sqrt(Math.Pow((x-zero),2) + Math.Pow((y-zero), 2));
            return distance;
        }

        static double getDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
