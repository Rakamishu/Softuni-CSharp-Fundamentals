using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus
    {
    class Rhombus
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            var spaces = n - stars;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < stars; col++)
                {
                    Console.Write("* ");
                }
                spaces--;
                stars++;
                Console.WriteLine();
            }

            spaces = 1;
            stars = n - spaces;
            for (int row = n; row < 2 * n; row++)
            {

                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < stars; col++)
                {
                    Console.Write("* ");
                }
                spaces++;
                stars--;
                Console.WriteLine();
            }
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
