using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}{0}", '+', GenerateFrom("- ", n - 2));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0} {1}{0}", '|', GenerateFrom("- ", n - 2));
            }
            Console.WriteLine("{0} {1}{0}", '+', GenerateFrom("- ", n - 2));
        }

        private static string GenerateFrom(string input, int times)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                builder.Append(input);
            }

            return builder.ToString();
        }
    }
}
