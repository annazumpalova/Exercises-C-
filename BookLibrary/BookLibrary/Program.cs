using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<PriceList> product = new List<PriceList>();
            for(int i=0; i<number; i++)
            {
                string[] priceAndproduct = Console.ReadLine().Split(' ', '-');
                PriceList lists = new PriceList() { Name = priceAndproduct[0],
                 Price =double.Parse(priceAndproduct[1]) };

                 if(product.Any(e => e.Name==lists.Name))
                 {
                 for(int s=0; s<product.Count; s++)
                 {
                 if(product[s].Name==lists.Name)
                 {

                 }
                 }
                 }
            }
        }
    }
}
