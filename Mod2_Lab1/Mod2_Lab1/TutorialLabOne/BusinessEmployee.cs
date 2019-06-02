using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialLabOne
{
    class BusinessEmployee: Employee
    {
        private double _bonusBudget = 1000;

        public BusinessEmployee(string name): base(name, 50000)
        {

        }

        public override string EmployeeStatus()
        {
            return ToString() + " with a budget of " + _bonusBudget;
        }
    }
}
