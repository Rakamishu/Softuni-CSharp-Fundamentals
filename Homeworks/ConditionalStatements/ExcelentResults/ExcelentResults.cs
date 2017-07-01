using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelentResults
{
    class ExcelentResults
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if(grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
