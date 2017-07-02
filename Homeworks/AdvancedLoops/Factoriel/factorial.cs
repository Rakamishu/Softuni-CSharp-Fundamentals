using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = 1;

            for(int i = 1; i <= n; i++)
            {
                num = num * i;
            }
            Console.WriteLine(num);
        }
    }
}
