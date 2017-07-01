using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDToBGN
{
    class USDToBGN
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double course = 1.79549;
            var formula = (usd * course);

            Console.WriteLine(Math.Round(formula, 2));
        }
    }
}
