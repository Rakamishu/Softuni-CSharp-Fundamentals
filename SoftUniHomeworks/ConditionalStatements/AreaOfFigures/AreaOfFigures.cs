using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var num1 = double.Parse(Console.ReadLine());
            var num2 = 0.0;

            switch (figure)
            {
                case "square":
                    Console.WriteLine(num1 * num1);
                    break;
                case "rectangle":
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(num1 * num2, 3));
                    break;
                case "circle":
                    Console.WriteLine(Math.Round(Math.PI * num1 * num1, 3));
                    break;
                case "triangle":
                    num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(num1 * num2 / 2, 3));
                    break;
            }
        }
    }
}
