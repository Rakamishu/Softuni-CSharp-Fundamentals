﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n));

            for(int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine(new string('*', 1) + new string(' ', n - 2) + new string ('*', 1));
            }

            Console.WriteLine(new string('*', n));
        }
    }
}
