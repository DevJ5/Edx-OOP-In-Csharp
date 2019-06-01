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
        private List<Student> StudentList = new List<Student>();
        private List<Teacher> TeacherList = new List<Teacher>();

        public Course(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            TeacherList.Add(teacher);
        }

        public void PrintStudentNames()
        {
            foreach (var student in StudentList)
            {
                Console.WriteLine($"{student.Id}: {student.FirstName} {student.LastName}");
            }
        }

        public void PrintTeacherNames()
        {
            foreach (Teacher teacher in TeacherList)
            {
                Console.WriteLine($"{teacher.FirstName} {teacher.LastName}");
            }
        }

        public int CountNumberOfStudents()
        {
            return StudentList.Count;
        }
    }
}
