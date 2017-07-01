using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double total = num;
            double bonus = 0;

            if(num <= 100)
            {
                bonus = bonus + 5; 
            }
            else if(num > 100 && num < 1000)
            {
                double percentage = num / 100 * 20;
                bonus = bonus + percentage;
            }
            else if (num > 1000)
            {
                double percentage = num / 100 * 10;
                bonus = bonus + percentage;
            }

            // if num is odd
            if (num % 2 == 0) 
            {
                bonus = bonus + 1;
            }

            // if last digit is 5
            if (num % 10 == 5) 
            {
                bonus = bonus + 2;
            }

            total = total + bonus;
            Console.WriteLine(bonus);
            Console.WriteLine(total);
        }
    }
}
