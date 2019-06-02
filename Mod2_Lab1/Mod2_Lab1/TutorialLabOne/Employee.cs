using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialLabOne
{
    abstract class Employee
    {
        private string _name;
        private double _baseSalary;
        private int _id;
        private static int _idCounter = 1;

        public Employee(string name, double baseSalary)
        {
            _name = name;
            _baseSalary = baseSalary;
            _id = _idCounter;
            _idCounter++;
        }

        public double GetBaseSalary()
        {
            return _baseSalary;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetEmployeeId()
        {
            return _id;
        }

        public override string ToString()
        {
            return $"{_id} {_name}";
        }

        public abstract string EmployeeStatus();
    }
}
