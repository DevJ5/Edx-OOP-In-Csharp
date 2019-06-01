using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class Student
    {
        private static int NumberOfStudents = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        private static int IdCounter = 101;


        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Id = IdCounter;
            NumberOfStudents++;
            IdCounter++;
        }

        public static int GetNumberOfStudents()
        {
            return NumberOfStudents;
        }
    }
}
