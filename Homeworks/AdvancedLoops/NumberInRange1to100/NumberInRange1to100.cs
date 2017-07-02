using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1to100
{
    class NumberInRange1to100
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.Write("Enter a number in the range [1...100]: ");

                var n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine("The number is {0}", n);
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
