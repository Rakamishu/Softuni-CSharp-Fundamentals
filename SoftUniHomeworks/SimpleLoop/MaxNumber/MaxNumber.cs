using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var max = int.MinValue; 

            for (int i = 1; i <= number; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if(num > max)
                {
                    max = num; 
                }
            }
            Console.WriteLine(max);
        }
    }
}
