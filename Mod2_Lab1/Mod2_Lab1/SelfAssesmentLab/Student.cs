using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class Student: Person
    {
        private List<Course> _coursesEnrolled = new List<Course>();
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public void AddEnrollment(Course course)
        {
            _coursesEnrolled.Add(course);
        }

    }
}
