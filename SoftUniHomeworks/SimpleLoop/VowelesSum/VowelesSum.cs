using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelesSum
{
    class VowelesSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a') { sum += 1; }
                else if (input[i] == 'e') { sum += 2; }
                else if (input[i] == 'i') { sum += 3; }
                else if (input[i] == 'o') { sum += 4; }
                else if (input[i] == 'u') { sum += 5; }
            }
            Console.WriteLine(sum);
        }
    }
}
