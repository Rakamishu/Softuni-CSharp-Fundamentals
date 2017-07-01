using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15
{
    class TimePlus15
    {
        static void Main(string[] args)
        {
            var inputHours = int.Parse(Console.ReadLine());
            var inputMinutes = int.Parse(Console.ReadLine());

            int hoursToSeconds = inputHours * 60;
            int totalSeconds = hoursToSeconds + inputMinutes + 15;
            int seconds = totalSeconds % 60;
            int minutes = totalSeconds / 60;

            if(minutes >= 24)
            {
                string display = string.Format("{0:00}", seconds);
                Console.WriteLine("0:" + display);
            }
            else
            {
                string display = string.Format("{0}:{1:00}", minutes, seconds);
                Console.WriteLine(display);
            }
        }
    }
}
