using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace daysum
{
    class daysum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var dolarInlev = double.Parse(Console.ReadLine());
            double payFormonth;
            payFormonth = n * m;
            double payForyear;
            payForyear = payFormonth * 12 + payFormonth * 2.5;


        }
    }
}
