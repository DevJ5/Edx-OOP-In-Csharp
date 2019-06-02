using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class Teacher: Person
    {
        private List<Course> _currentCoursesTaught = new List<Course>();
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public void AddCourseTaught(Course course)
        {
            _currentCoursesTaught.Add(course);
        }

        public void PrintAllCoursesTaught()
        {
            foreach (var course in _currentCoursesTaught)
            {
                Console.WriteLine(course);
            }
        }

        public override void Laugh()
        {
            Console.WriteLine("Muwahaha");
        }

    }
}
