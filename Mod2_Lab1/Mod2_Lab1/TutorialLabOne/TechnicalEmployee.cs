using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialLabOne
{
    class TechnicalEmployee: Employee
    {
        private int _successfulCheckIns = 5;

        public TechnicalEmployee(string name, double baseSalary) : base(name, baseSalary)
        {
           
        }

        public override string EmployeeStatus()
        {
            return ToString() + " has " + _successfulCheckIns + " successful check ins.";
        }
    }
}
