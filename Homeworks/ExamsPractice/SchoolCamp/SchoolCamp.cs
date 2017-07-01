using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var type = Console.ReadLine().ToLower();
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());

            var price = 0.0;
            var discount = 0;
            var price_final = 0.0;

            if(students >= 50)
            {
                discount = 50;
            }
            else if(students >= 20 && students < 50)
            {
                discount = 15;
            }
            else if(students >= 10 && students < 20)
            {
                discount = 5;
            }



            if (season == "winter")
            {                
                if (type == "girls")
                {
                    price = 9.60 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Gymnastics {0:f2} lv.", price_final);
                }
                else if (type == "boys")
                {
                    price = 9.60 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Judo {0:f2} lv.", price_final);
                }
                else if (type == "mixed")
                {
                    price = 10 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Ski {0:f2} lv.", price_final);
                }
            }
            else if (season == "spring")
            {
                if (type == "girls")
                {
                    price = 7.20 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }

                    Console.WriteLine("Athletics {0:f2} lv.", price_final);
                }
                else if (type == "boys")
                {
                    price = 7.20 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }

                    Console.WriteLine("Tennis {0:f2} lv.", price_final);
                }
                else if (type == "mixed")
                {
                    price = 9.50 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Cycling {0:f2} lv.", price_final);
                }
            }
            else if(season == "summer")
            {
                if (type == "girls")
                {
                    price = 15 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Volleyball {0:f2} lv.", price_final);
                }
                else if (type == "boys")
                {
                    price = 15 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Football {0:f2} lv.", price_final);
                }
                else if (type == "mixed")
                {
                    price = 20 * students * nights;
                    if (students >= 10)
                    {
                        price_final = price - (price * discount) / 100;
                    }
                    else
                    {
                        price_final = price;
                    }
                    Console.WriteLine("Swimming {0:f2} lv.", price_final);
                }
            }
        }
    }
}
