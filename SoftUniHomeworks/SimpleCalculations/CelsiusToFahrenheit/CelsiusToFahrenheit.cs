using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());

            var formula = c * 1.8 + 32;
            Console.WriteLine(Math.Round(formula, 2));
        }
    }
}
