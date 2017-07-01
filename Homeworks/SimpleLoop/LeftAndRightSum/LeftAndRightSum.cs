using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var first = 0;
            var second = 0;

            for (int i = 1; i <= n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                first += number;
            }

            for (int ii = 1; ii <= n; ii++)
            {
                var number = int.Parse(Console.ReadLine());
                second += number;
            }
            if(first == second)
            {
                Console.WriteLine("Yes, sum = {0}", first);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(first - second));
            }
        }
    }
}
