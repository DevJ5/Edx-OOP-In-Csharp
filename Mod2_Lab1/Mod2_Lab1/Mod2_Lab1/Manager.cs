using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // Inheritance:
    class Manager: Employee
    {
        private char payRateIndicator;
        private Employee[] employees;

        public override string ToString()
        {
            return this.FirstName + " " + this.Lastname;
        }

        internal override void Login()
        {
            Console.WriteLine("Successfully logged in.");
        }

        public override void LogOut()
        {
            Console.WriteLine("Succesfully logged out.");
        }

        new public void EatLunch()
        {
            Console.WriteLine("Om nom nommmm");
        }
    }
}
