    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var max = -9999999999;
            var total = 0;

            for (int i = 0; i < num; i++)
            {
                var n = int.Parse(Console.ReadLine());
                total += n;
                if(n > max)
                {
                    max = n;
                }
            }
            if(total - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (total - max));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("diff = " + Math.Abs((max - (total - max))));
            }
        }
    }
}
