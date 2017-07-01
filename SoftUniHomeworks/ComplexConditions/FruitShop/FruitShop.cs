using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());

            if(day == "saturday" || day == "sunday")
            {
                if (product == "banana") { Console.WriteLine(amount * 2.7); }
                else if (product == "apple") { Console.WriteLine(amount * 1.25); }
                else if (product == "orange") { Console.WriteLine(amount * 0.9); }
                else if (product == "grapefruit") { Console.WriteLine(amount * 1.6); }
                else if (product == "kiwi") { Console.WriteLine(amount * 3); }
                else if (product == "pineapple") { Console.WriteLine(amount * 5.6); }
                else if (product == "grapes") { Console.WriteLine(amount * 4.2); }
                else { Console.WriteLine("error"); }
            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (product == "banana") { Console.WriteLine(amount * 2.5); }
                else if (product == "apple") { Console.WriteLine(amount * 1.2); }
                else if (product == "orange") { Console.WriteLine(amount * 0.85); }
                else if (product == "grapefruit") { Console.WriteLine(amount * 1.45); }
                else if (product == "kiwi") { Console.WriteLine(amount * 2.7); }
                else if (product == "pineapple") { Console.WriteLine(amount * 5.5); }
                else if (product == "grapes") { Console.WriteLine(amount * 3.85); }
                else { Console.WriteLine("error"); }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
