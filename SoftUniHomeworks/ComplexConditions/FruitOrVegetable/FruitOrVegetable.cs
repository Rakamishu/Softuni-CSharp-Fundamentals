using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string[] fruits = {"banana", "kiwi", "cherry", "lemon", "grapes", "apple"};
            string[] vegetables = {"tomato", "cucumber", "pepper", "carrot"};

            var input = Console.ReadLine();

            if (fruits.Contains(input))
            {
                Console.WriteLine("fruit");
            }
            else if(vegetables.Contains(input))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");                
            }
        }
    }
}
