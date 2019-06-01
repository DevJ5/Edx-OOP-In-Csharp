using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public Car()
        {
            instances++;
        }

        public Car(string color, int year)
        {
            Color = color;
            Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            Year = year;
            Mileage = mileage;
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }
    }
}
