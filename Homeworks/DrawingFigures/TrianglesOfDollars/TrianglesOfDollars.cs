using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesOfDollars
{
    class TrianglesOfDollars
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(GenerateFrom("$ ", i)); 
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
