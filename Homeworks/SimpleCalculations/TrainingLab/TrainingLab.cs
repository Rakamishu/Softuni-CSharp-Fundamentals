using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()) * 100 - 100;
            double h = double.Parse(Console.ReadLine()) * 100;
            int desk_size
            int desk_size = 70; 

            double area_per_desk = w / desk_size;
            double total_desks = area_per_desk / desk_size;

            Console.WriteLine(area_per_desk);
        }
    }
}
