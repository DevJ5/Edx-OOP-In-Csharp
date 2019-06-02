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
        public int Years { get; set; }
        private List<Course> courses = new List<Course>();

        public Degree(string name, int years)
        {
            Name = name;
            Years = years;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public override string ToString()
        {
            return Name + " " + Years;
        }
    }
}
