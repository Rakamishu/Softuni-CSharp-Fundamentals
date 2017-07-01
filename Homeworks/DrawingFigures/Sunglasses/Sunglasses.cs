using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int glassesSize = int.Parse(Console.ReadLine());


            Console.WriteLine("{0}{1}{0}", new string('*', 2 * glassesSize), new string(' ', glassesSize));

            int glassBodyHeight = glassesSize - 2;
            for(int row = 0; row < glassBodyHeight; row++)
            {
                char separator;
                if(glassesSize % 2 == 0)
                {
                    if (row == glassBodyHeight / 2 - 1)
                    {
                        separator = '|';
                    }
                    else
                    {
                        separator = ' ';
                    }
                }
                else
                {
                    if (row == glassBodyHeight / 2)
                    {
                        separator = '|';
                    }
                    else
                    {
                        separator = ' ';
                    }
                }
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * glassesSize - 2), new string (separator, glassesSize));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * glassesSize), new string(' ', glassesSize));
        }
    }
}
