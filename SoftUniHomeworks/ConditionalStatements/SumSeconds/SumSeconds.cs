using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int contestant1 = int.Parse(Console.ReadLine());
            int contestant2 = int.Parse(Console.ReadLine());
            int contestant3 = int.Parse(Console.ReadLine());

            int totalSeconds = contestant1 + contestant2 + contestant3;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;

            string display = string.Format("{0}:{1:00}", minutes, seconds);
            Console.WriteLine(display);
        }
    }
}
