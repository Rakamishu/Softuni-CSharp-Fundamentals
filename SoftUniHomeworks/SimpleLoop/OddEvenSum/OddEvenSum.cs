using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var even = 0;
            var odd = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    odd += number;
                }
                else
                {
                    even += number;
                }
            }
            
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", even);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(even - odd));
            }

        }
    }
}
