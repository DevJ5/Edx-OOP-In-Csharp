using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Car
    {
        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
