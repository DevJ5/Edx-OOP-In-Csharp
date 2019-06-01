using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class Degree
    {
        public string Name { get; set; }
        private List<Course> CourseList = new List<Course>();

        public Degree(string name)
        {
            Name = name;
        }

        public void AddCourse(Course course)
        {
            CourseList.Add(course);
        }
    }
}
