using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine();
            switch(animal) {
                case "dog":
                    Console.WriteLine("dog->mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("crocodile->reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("tortoise->reptile");
                    break;
                case "snake":
                    Console.WriteLine("snake->reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
                    
            } 
        }
    }
}
