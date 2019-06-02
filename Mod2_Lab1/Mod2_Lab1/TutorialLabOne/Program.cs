using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialLabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("bert", 100000);
            Console.WriteLine(employee1.EmployeeStatus());

            TechnicalEmployee techy = new TechnicalEmployee("herman");
            Console.WriteLine(techy.EmployeeStatus());
            Console.WriteLine(techy.GetName());

            Console.WriteLine("------------------------------");

            var employee3 = new Employee("Libby", 2000);
            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee4 = new TechnicalEmployee("Zaynah");
            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee5 = new BusinessEmployee("Winter");

            // Output to the console window
            Console.WriteLine(employee3.EmployeeStatus() + "..." + employee4.EmployeeStatus() + "..." + employee5.EmployeeStatus());

        }
    }
}
