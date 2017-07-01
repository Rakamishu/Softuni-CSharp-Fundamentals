using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            var formula = height * width / 2;
            var area = Math.Round(formula, 2);
            Console.WriteLine(area);
        }
    }
}
