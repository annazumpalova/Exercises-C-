using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace equalSum
{
    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for(int i=0; i<n;i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                string dateAstext = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateAstext, "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = decimal.Parse(Console.ReadLine());
                int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = daysInMonth * capsuleCount * pricePerCapsule;
                totalPrice += price;
                Console.WriteLine("The price for the coffee is: ${0:F2}", price);
            }
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
