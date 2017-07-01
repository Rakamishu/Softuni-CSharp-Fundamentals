using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusToDegrees
{
    class RadiusToDegrees
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            var formula = rad * (180 / Math.PI);
            Console.WriteLine(Math.Round(formula, 2));
        }
    }
}
