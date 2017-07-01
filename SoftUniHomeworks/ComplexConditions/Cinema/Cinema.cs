using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 0.0;

            int seats = r * c;
            switch (type)
            {
                case "premiere":
                    result = seats * 12.00;
                    Console.WriteLine("{0:f2}", result);
                    break;
                case "normal":
                    result = seats * 7.50;
                    Console.WriteLine("{0:f2}", result);
                    break;
                case "discount":
                    result = seats * 5.00;
                    Console.WriteLine("{0:f2}", result);
                    break;

            }
        }
    }
}
