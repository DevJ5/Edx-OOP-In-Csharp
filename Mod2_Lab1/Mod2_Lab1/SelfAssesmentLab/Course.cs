using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class Course
    {
        public string Name { get; set; }
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Student> _students = new List<Student>();

        public Course(string name)
        {
            Name = name;
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
