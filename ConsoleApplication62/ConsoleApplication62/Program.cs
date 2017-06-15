using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converstSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInmeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes= int.Parse(Console.ReadLine());
            int seconds= int.Parse(Console.ReadLine());
           float hoursInminutes =(float) hours * 60;
            float minutesInseconds = (float) (hoursInminutes + minutes) * 60;
            float allSeconds =(float) minutesInseconds + seconds;
            float metersPerseconds =(float) distanceInmeters / allSeconds;
            float metersInkilometers = (float) distanceInmeters / 1000;
            float secondsInminutes = (float)seconds / 60;
            float minutesInhours =(float)(minutes+ secondsInminutes) / 60;
            float allHours =(float) minutesInhours + hours;
     float kilometersPerhours =(float)metersInkilometers / allHours;
      float metersInmiles = (float) distanceInmeters / 1609;
         float milesPerhours = (float) metersInmiles / allHours;
            Console.WriteLine("{0:F6}", metersPerseconds);
            Console.WriteLine("{0:F6}",kilometersPerhours);
            Console.WriteLine("{0:F6}", milesPerhours);
        }
    }
}
