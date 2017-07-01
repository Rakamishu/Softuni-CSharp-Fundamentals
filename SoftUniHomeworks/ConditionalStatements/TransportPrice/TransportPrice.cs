using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            //prices
            double taxi_start = 0.7;
            double taxi_day = 0.79;
            double taxi_night = 0.9;
            double bus = 0.09;
            double train = 0.06;

            //define total
            double total_taxi = 0.0;
            double total_bus = 0.0;
            double total_train = 0.0;

            if(time == "day")
            {
                total_taxi = Math.Round(n * taxi_day + taxi_start, 2);
                total_bus = Math.Round(n * bus, 2);
                total_train = Math.Round(n * train, 2);

                if(n >= 20 && n < 100)
                {
                    if (total_taxi < total_bus)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_taxi));
                    }
                    else if (total_bus < total_taxi)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_bus));
                    }
                }
                else if (n >= 100)
                {
                    if (total_taxi < total_bus && total_taxi < total_train)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_taxi));
                    }
                    else if (total_bus < total_taxi && total_bus < total_train)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_bus));
                    }
                    else if (total_train < total_taxi && total_train < total_bus)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_train));
                    }
                }
                else if (n < 20)
                {
                    Console.WriteLine(String.Format("{0:0.00}", total_taxi));
                }
            }
            else if(time == "night")
            {
                total_taxi = Math.Round(n * taxi_night + taxi_start, 2);
                total_bus = Math.Round(n * bus, 2);
                total_train = Math.Round(n * train, 2);

                if (n >= 20 && n < 100)
                {
                    if (total_taxi < total_bus)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_taxi));
                    }
                    else if (total_bus < total_taxi)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_bus));
                    }
                }
                else if (n >= 100)
                {
                    if (total_taxi < total_bus && total_taxi < total_train)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_taxi));
                    }
                    else if (total_bus < total_taxi && total_bus < total_train)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_bus));
                    }
                    else if (total_train < total_taxi && total_train < total_bus)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", total_train));
                    }
                }
                else if (n < 20)
                {
                    Console.WriteLine(String.Format("{0:0.00}", total_taxi));
                }
            }

        }
    }
}
