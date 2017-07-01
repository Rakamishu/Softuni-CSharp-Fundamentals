using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPosition
{
    class EvenOddPosition
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var total_odd = 0.0;
            var total_even = 0.0;
            var odd_max = -99999999.0;
            var even_max = -99999999.0;
            var odd_min = 99999999.0;
            var even_min = 99999999.0;


            for (int i = 1; i <= num; i++)
            {
                var n = double.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    total_even += n;
                    if(n > even_max)
                    {
                        even_max = n;
                    }
                    else
                    {
                        even_min = n;
                    }
                }
                else
                {
                    total_odd += n;
                    if (n > odd_max)
                    {
                        odd_max = n;
                    }
                    else
                    {
                        odd_min = n;
                    }
                }
            }
            
            if(num == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=no");
                Console.WriteLine("OddMax=no");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=no");
                Console.WriteLine("EvenMax=no");
            }
            else if(num == 1)
            {
                Console.WriteLine("OddSum=" + total_odd);
                Console.WriteLine("OddMin=" + odd_min);
                Console.WriteLine("OddMax=" + odd_max);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=no");
                Console.WriteLine("EvenMax=no");
            }
            else
            {
                Console.WriteLine("OddSum=" + total_odd);
                Console.WriteLine("OddMin=" + odd_min);
                Console.WriteLine("OddMax=" + odd_max);
                Console.WriteLine("EvenSum=" + total_even);
                Console.WriteLine("EvenMin=" + even_min);
                Console.WriteLine("EvenMax=" + even_max);
            }
        }
    }
}
