using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTable
{
    class NumbersTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int row = 1; row <= n; row++)
            {
                int left = row;
                int right = n - 1;

                for(int col = 1; col <= n; col++)
                {
                    if(left <= n)
                    {
                        Console.Write("{0} ", left);
                        left++;
                    }
                    else
                    {
                        Console.Write("{0} ", right);
                        right--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
