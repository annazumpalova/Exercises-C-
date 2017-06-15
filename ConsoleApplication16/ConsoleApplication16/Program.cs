using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());
            var washingmasch = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());
            int toys = 0;
            int money = 0;
            for(int i=1; i<year; i++) {
            if(i%2==0) {
                    money+= (i / 2) * 10;
            } else {
                    toys++;
            }
            }
            double toysMoney = toys * priceToy;
            double brothersMoney = toys * 1;
            double totalMoneyfromToys = toysMoney - brothersMoney;
            double totalMoney = money + totalMoneyfromToys;
            if(totalMoney>=washingmasch) {
                Console.WriteLine("Yes! {0:F2}", totalMoney-washingmasch);
            } else if(totalMoney<washingmasch) { 
                Console.WriteLine("No!{0:F2}", washingmasch - totalMoney);
            }
                   
        
        }
    }
}
