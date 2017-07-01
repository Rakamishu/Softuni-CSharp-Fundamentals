using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            var izpit_chas = int.Parse(Console.ReadLine()); 
            var izpit_minuti = int.Parse(Console.ReadLine()); 
            var pristigane_chas = int.Parse(Console.ReadLine()); 
            var pristigane_minuti = int.Parse(Console.ReadLine()); 

            DateTime izpit = new DateTime(2017, 1, 1, izpit_chas, izpit_minuti, 0); //4asa na izpita
            DateTime pristigane = new DateTime(2017, 1, 1, pristigane_chas, pristigane_minuti, 0); //4asa na pristigane
            TimeSpan difference = (pristigane - izpit); //razlikata v 4asovete.

            if (pristigane > izpit) // Izpita ve4e e zapo4nal.
            {
                Console.WriteLine("Late");
                if (difference.Hours >= 1) // Za da ugodim na judge-a, ako zakasnqvame s pove4e ot 4as, pokazvame i 4asa. 
                {
                    Console.WriteLine(String.Format("{0}:{1:00} hours after the start", difference.Hours, difference.Minutes));
                }
                else if (difference.Hours == 0) // Ako zakasnqvame s nqkolko minuti, pokazvame samo minutite.
                {
                    Console.WriteLine(String.Format("{0} minutes after the start", difference.Minutes));
                }

            }
            else if (pristigane == izpit) // Pristigame to4no na vreme. 
            {
                Console.WriteLine("On time");
            }
            else if (pristigane < izpit) // Izpita ne e zapo4nal
            {
                if (Math.Abs(difference.Hours) >= 1) // Podranili sme s nad ili to4no 1 4as.
                {
                    Console.WriteLine("Early");
                    Console.WriteLine(String.Format("{0}:{1:00} hours before the start", Math.Abs(difference.Hours), Math.Abs(difference.Minutes)));
                }
                else if (Math.Abs(difference.Minutes) <= 30) // Podranili sme s po malko ot polovin 4as. Pokazvame samo minutite.
                {
                    Console.WriteLine("On time");
                    Console.WriteLine(String.Format("{0} minutes before the start", Math.Abs(difference.Minutes)));
                }
                else if(Math.Abs(difference.Minutes) > 30) //Podranili sme s pove4e ot polovin 4as. Otnovo, malko izli6no, no za da ugodim na judge-a, vadim s kolko minuti sme podranili.
                {
                    Console.WriteLine("Early");
                    Console.WriteLine(String.Format("{0} minutes before the start", Math.Abs(difference.Minutes)));
                }
            }
        }
    }
}
