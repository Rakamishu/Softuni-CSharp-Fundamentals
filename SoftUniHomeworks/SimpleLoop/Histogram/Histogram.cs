using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            var total_p1 = 0.0;
            var total_p2 = 0.0;
            var total_p3 = 0.0;
            var total_p4 = 0.0;
            var total_p5 = 0.0;
            var total_entries = 0.0;

            if (number >= 1 && number <= 1000)
            {
                for (int i = 0; i < number; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num < 200)
                    {
                        total_entries++;
                        p1 = total_entries / 20 * 100;
                    }
                    else if (num >= 200 && num <= 399)
                    {
                        total_entries++;
                        p2 = total_entries / 20 * 100;
                    }
                    else if (num >= 400 && num <= 599)
                    {
                        total_entries++;
                        p3 = total_entries / 20 * 100;
                    }
                    else if (num >= 600 && num <= 799)
                    {
                        total_entries++;
                        p4 = total_entries / 20 * 100;
                    }
                    else if (num >= 800)
                    {
                        total_entries++;
                        p5 = total_entries / 20 * 100;
                    }
                    total_entries++;
                }
                Console.WriteLine("{0:F2}% \n{1:F2}% \n{2:F2}% \n{3:F2}% \n{4:F2}%", p1, p2, p3, p4, p5);
            }
        }
    }
}
