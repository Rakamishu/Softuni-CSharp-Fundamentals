using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterdate = Console.ReadLine();
            DateTime birthdate = DateTime.ParseExact(enterdate, "dd-MM-yyyy", null);
            DateTime thousanddays = birthdate.AddDays(999);
            Console.WriteLine(thousanddays.ToString("dd-MM-yyyy"));
        }
    }
}
