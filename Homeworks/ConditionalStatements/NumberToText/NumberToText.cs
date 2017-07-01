using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class NumberToText
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var endDigit = num % 10;
            var interval = " ";

            Transformer transform = new Transformer();
            
            if(num >= 20 && num < 30)
            {
                if(num == 20)
                {
                    interval = "";
                }
                Console.WriteLine("twenty" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 30 && num < 40)
            {
                if (num == 30)
                {
                    interval = "";
                }
                Console.WriteLine("thirty" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 40 && num < 50)
            {
                if (num == 40)
                {
                    interval = "";
                }
                Console.WriteLine("forty" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 50 && num < 60)
            {
                if (num == 50)
                {
                    interval = "";
                }
                Console.WriteLine("fifty" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 60 && num < 70)
            {
                if (num == 60)
                {
                    interval = "";
                }
                Console.WriteLine("sixty" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 70 && num < 80)
            {
                if (num == 70)
                {
                    interval = "";
                }
                Console.WriteLine("seventy" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 80 && num < 90)
            {
                if (num == 80)
                {
                    interval = "";
                }
                Console.WriteLine("eighty" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 90 && num < 100)
            {
                if (num == 90)
                {
                    interval = "";
                }
                Console.WriteLine("ninety" + interval + transform.FindNumber(endDigit));
            }
            else if (num >= 1 && num < 20)
            {
                Console.WriteLine(transform.FindNumber(num));
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (num == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }

    class Transformer
    {
        public string FindNumber(int number)
        {
            if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else if (number == 3)
            {
                return "three";
            }
            else if (number == 4)
            {
                return "four";
            }
            else if (number == 5)
            {
                return "five";
            }
            else if (number == 6)
            {
                return "six";
            }
            else if (number == 7)
            {
                return "seven";
            }
            else if (number == 8)
            {
                return "eight";
            }
            else if (number == 9)
            {
                return "nine";
            }
            else if (number == 10)
            {
                return "ten";
            }
            else if (number == 11)
            {
                return "eleven";
            }
            else if (number == 12)
            {
                return "twelve";
            }
            else if (number == 13)
            {
                return "thirteen";
            }
            else if (number == 14)
            {
                return "fourteen";
            }
            else if (number == 15)
            {
                return "fifteen";
            }
            else if (number == 16)
            {
                return "sixteen";
            }
            else if (number == 17)
            {
                return "seventeen";
            }
            else if (number == 18)
            {
                return "eighteen";
            }
            else if (number == 19)
            {
                return "nineteen";
            }
            return "";
        }
    }
}
