using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car("White", 2010);
            // Using dot notation to call members on Car1
            Car1.Mileage = 11000;

            Console.WriteLine(Car1.Color);

            var Car2 = new Car(2019, 150000);
            Console.WriteLine(Car2.Year);

            Console.WriteLine($"The number of cars made: {Car.CountCars()}");
        }
    }
}
