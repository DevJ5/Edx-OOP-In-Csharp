using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    // Abstract because we wont be instantiating Employee itself.
    abstract class Employee
    {
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }

        internal virtual void Login()
        {
            Console.WriteLine("Logged in...");
        }

        public abstract void LogOut();

        public void EatLunch()
        {
            Console.WriteLine("Om nom nom");
        }

    }
}
