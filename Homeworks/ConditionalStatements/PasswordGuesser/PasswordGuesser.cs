using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuesser
{
    class PasswordGuesser
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var password = "s3cr3t!P@ssw0rd";

            if(input == password)
            {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
