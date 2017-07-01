using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    class Magazin
    {
        static void Main(string[] args)
        {
            var cena_puzzle = 2.6;
            var cena_kukla = 3.0;
            var cena_me4e = 4.1;
            var cena_minion = 8.2;
            var cena_kamion = 2.0;

            var input_exkurzia = double.Parse(Console.ReadLine());
            var input_broi_puzzles = int.Parse(Console.ReadLine());
            var input_broi_kukli = int.Parse(Console.ReadLine());
            var input_broi_me4eta = int.Parse(Console.ReadLine());
            var input_broi_minioni = int.Parse(Console.ReadLine());
            var input_broi_kamioni = int.Parse(Console.ReadLine());

            var naem = 0.0;
            var otstapka = 0.0;
            var pe4alba = 0.0;

            var total_pora4ka_igra4ki = input_broi_puzzles + input_broi_kukli + input_broi_me4eta + input_broi_minioni + input_broi_kamioni;
            var total_pora4ka_suma = 
                (input_broi_puzzles * cena_puzzle) + 
                (input_broi_kukli * cena_kukla) + 
                (input_broi_me4eta * cena_me4e) + 
                (input_broi_minioni * cena_minion) + 
                (input_broi_kamioni * cena_kamion);

            if (total_pora4ka_igra4ki >= 50)
            {
                otstapka = (total_pora4ka_suma * 25) / 100;
            }
            pe4alba = total_pora4ka_suma - otstapka;
            naem = (pe4alba * 10) / 100;
            pe4alba = pe4alba - naem;
            

            if (pe4alba >= input_exkurzia)
            {
                var money_left = pe4alba - input_exkurzia;
                Console.WriteLine("Yes! {0:f2} lv left.", money_left);
            }
            else
            {
                var money_needed = input_exkurzia - pe4alba;
                Console.WriteLine("Not enough money! {0:f2} lv needed.", money_needed);
            }
        }
    }
}
