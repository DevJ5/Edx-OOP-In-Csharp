using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var ITProgram = new UProgram("Information Technology");

            Student BertWasbeer = new Student("Bert", "Wasbeer", 19);
            Student ErnieWasbeer = new Student("Ernie", "Wasbeer", 20);
            Student HenkWasbeer = new Student("Henk", "Wasbeer", 21);
            Console.WriteLine($"There are currently {Student.GetNumberOfStudents()} students.");

            var CsharpCourse = new Course("Programming with C#");
            CsharpCourse.AddStudent(BertWasbeer);
            CsharpCourse.AddStudent(ErnieWasbeer);
            CsharpCourse.AddStudent(HenkWasbeer);

            CsharpCourse.PrintStudentNames();

            var HenryTheTeacher = new Teacher("Henry", "Wilson");
            var BarryTheTeacher = new Teacher("Barry", "Wilson");
            CsharpCourse.AddTeacher(HenryTheTeacher);
            CsharpCourse.AddTeacher(BarryTheTeacher);

            CsharpCourse.PrintTeacherNames();

            Degree BachelorsDegree = new Degree("Bachelor");
            BachelorsDegree.AddCourse(CsharpCourse);

            Console.WriteLine($"{ITProgram.Name} - {BachelorsDegree.Name}");
            Console.WriteLine($"In {CsharpCourse.Name} there are currently {CsharpCourse.CountNumberOfStudents()} students enrolled.");
            Console.WriteLine($"Students enrolled: ");
            CsharpCourse.PrintStudentNames();
        }
    }
}
