using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var amount = double.Parse(Console.ReadLine());
            double result = 0.0;

            if(town == "sofia")
            {
                if (amount >= 0 && amount <= 500) {                 result = amount * (5.0 / 100);    }
                else if (amount >= 500 && amount <= 1000) {         result = amount * (7.0 / 100);    }
                else if (amount >= 1000 && amount <= 10000) {       result = amount * (8.0 / 100);    }
                else if (amount > 10000) {                          result = amount * (12.0 / 100); }
                Console.WriteLine("{0:f2}", result);
            }
            else if (town == "varna")
            {
                if (amount >= 0 && amount <= 500) { result = amount * (4.5 / 100); }
                else if (amount >= 500 && amount <= 1000) { result = amount * (7.5 / 100); }
                else if (amount >= 1000 && amount <= 10000) { result = amount * (10.0 / 100); }
                else if (amount > 10000) { result = amount * (13.0 / 100); }
                Console.WriteLine("{0:f2}", result);
            }
            else if (town == "plovdiv")
            {
                if (amount >= 0 && amount <= 500) { result = amount * (5.5 / 100); }
                else if (amount >= 500 && amount <= 1000) { result = amount * (8.0 / 100); }
                else if (amount >= 1000 && amount <= 10000) { result = amount * (12.0 / 100); }
                else if (amount > 10000) { result = amount * (14.5 / 100); }
                Console.WriteLine("{0:f2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
