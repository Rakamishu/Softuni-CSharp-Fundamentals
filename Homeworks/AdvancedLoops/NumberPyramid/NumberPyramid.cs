using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int num = 1;

            while (num <= n)
            {
                for(int i = 0; i < counter; i++)
                {
                    Console.Write("{0} ", num);
                    num++;
                    if(num > n)
                    {
                        break;
                    }
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}
