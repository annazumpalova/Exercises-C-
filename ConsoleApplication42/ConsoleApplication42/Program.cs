using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            var nachalo = int.Parse(Console.ReadLine());
            var krai= int.Parse(Console.ReadLine());
            var max= int.Parse(Console.ReadLine());
            int counter = 0;
            for(int i=1; i<=nachalo; i++) {
            for(int k=1; k<=krai; k++) {
                    counter++;
                    if(counter>max) {
                        break;
                    } Console.Write("<{0}-{1}>", i, k);
            }
            }
        }
    }
}
