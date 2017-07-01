using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsPractice
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            var price_whiskey = double.Parse(Console.ReadLine()); //50
            var bira = double.Parse(Console.ReadLine()); //10
            var vino = double.Parse(Console.ReadLine()); //3.5
            var rakia = double.Parse(Console.ReadLine()); //6.5
            var whiskey = double.Parse(Console.ReadLine()); //1
            var price_vino = 0.0;
            var price_bira = 0.0;
            var total = 0.0;

            price_vino = (price_whiskey / 2) - (0.4 * (price_whiskey / 2));
            price_bira = (price_whiskey / 2) - (0.8 * (price_whiskey / 2));


            total += whiskey * price_whiskey; //whiskeyto
            total += rakia * (price_whiskey / 2); //rakiata
            total += vino * price_vino; //vinoto
            total += bira * price_bira; //birata


            Console.WriteLine("{0:f2}", total);
        }
    }
}
