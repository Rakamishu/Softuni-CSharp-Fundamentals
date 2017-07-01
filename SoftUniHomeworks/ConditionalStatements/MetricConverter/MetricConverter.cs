using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();
            var intermediateMeters = 0.0;
            var result = 0.0;

            #region Input
            if (from == "mm")
            {
                intermediateMeters = num / 1000;
            }
            else if (from == "cm")
            {
                intermediateMeters = num / 100;
            }
            else if (from == "mi")
            {
                intermediateMeters = num / 0.000621371192;
            }
            else if (from == "in")
            {
                intermediateMeters = num / 39.3700787;
            }
            else if (from == "km")
            {
                intermediateMeters = num / 0.001;
            }
            else if (from == "ft")
            {
                intermediateMeters = num / 3.2808399;
            }
            else if (from == "yd")
            {
                intermediateMeters = num / 1.0936133;
            }
            else if (from == "m")
            {
                intermediateMeters = num;
            }
            #endregion


            #region Output
            if (to == "mm")
            {
                result = intermediateMeters * 1000;
            }
            else if (to == "cm")
            {
                result = intermediateMeters * 100;
            }
            else if (to == "mi")
            {
                result = intermediateMeters * 0.000621371192;
            }
            else if (to == "in")
            {
                result = intermediateMeters * 39.3700787;
            }
            else if (to == "km")
            {
                result = intermediateMeters * 0.001;
            }
            else if (to == "ft")
            {
                result = intermediateMeters * 3.2808399;
            }
            else if (to == "yd")
            {
                result = intermediateMeters * 1.0936133;
            }
            else if (to == "m")
            {
                result = intermediateMeters;
            }
            #endregion

            Console.WriteLine(result + " " + to);
        }
    }
}
