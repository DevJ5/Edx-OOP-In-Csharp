using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class DrinksMachine
    {
        // A private field:
        private int age;
        private string make;

        // A public property that acts as an interface:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // We can do validation inside the setter:
                if(value < 10)
                {
                    Console.WriteLine("less than 10");
                }
                else age = value;
            }
        }

        // Because these get and set are basic, an auto property can be used.
        public string Make
        {
            get
            {
                return make;
            }
            // Omitting the set, makes the field read only.
            set
            {
                make = value;
            }
        }

        // This is an example of an auto property. Private field is created in the background.
        public string Model { get; set; }

        // Constructors (overloaded):
        public DrinksMachine(int age)
        {
            this.Age = age;
        }

        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public DrinksMachine(int age, string make, string model)
        {
            this.Make = make;
            this.Model = model;
            this.Age = age;
        }
    }
}
