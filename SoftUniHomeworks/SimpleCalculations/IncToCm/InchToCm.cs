using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncToCm
{
    class InchToCm
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeteres = " + a*2.54);
        }
    }
}
