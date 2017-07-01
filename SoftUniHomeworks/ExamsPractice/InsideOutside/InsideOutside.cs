using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsideOutside
{
    class InsideOutside
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var xOfPoint = double.Parse(Console.ReadLine());
            var yOfPoint = double.Parse(Console.ReadLine());

            if (xOfPoint >= x1 && xOfPoint <= x2 && yOfPoint >= y1 && yOfPoint <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
