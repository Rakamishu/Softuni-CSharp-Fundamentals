using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());

            var height = Math.Abs(y1 - y2);
            var width = Math.Abs(x1 - x2);

            var area = height * width;
            var perimeter = 2 * (width + height);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
