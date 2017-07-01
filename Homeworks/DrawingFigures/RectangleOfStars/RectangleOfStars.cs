using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfStars
{
    class RectangleOfStars
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                Console.Write("*");
                for(var c = 1; c < num; c++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
