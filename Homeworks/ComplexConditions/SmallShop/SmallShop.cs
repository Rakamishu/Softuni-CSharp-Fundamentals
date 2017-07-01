using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var amount = double.Parse(Console.ReadLine());

            if(town == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.5);
                }
                else if(product == "water")
                {
                    Console.WriteLine(amount * 0.8);
                }
                else if(product == "beer")
                {
                    Console.WriteLine(amount * 1.2);
                }
                else if(product == "sweets")
                {
                    Console.WriteLine(amount * 1.45);
                }
                else if(product == "peanuts")
                {
                    Console.WriteLine(amount * 1.6);
                }
            } 
            else if(town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.4);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amount * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amount * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.5);
                }
            }
            else if(town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(amount * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(amount * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(amount * 1.1);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(amount * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(amount * 1.55);
                }
            }
        }
    }
}
