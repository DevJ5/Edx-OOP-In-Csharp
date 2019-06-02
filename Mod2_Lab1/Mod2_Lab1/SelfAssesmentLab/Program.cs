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
            // Class hierarchy:
            // A university
            University universiteitUtrecht = new University("Universiteit Utrecht", "Domplein 29", "3512 JE", "Utrecht");
            // has multiple programs
            UProgram informationTechnology = new UProgram("Information Technology");
            UProgram biology = new UProgram("Biology");
            universiteitUtrecht.AddProgram(informationTechnology);
            universiteitUtrecht.AddProgram(biology);
            // A program
            // has 2 degrees: Bachelor and Master
            Degree bachelorsIt = new Degree("Bachelors", 3);
            Degree mastersIt = new Degree("Masters", 1);
            informationTechnology.AddDegree(bachelorsIt);
            informationTechnology.AddDegree(mastersIt);
            // A degree 
            // has multiple courses
            Course cSharp101 = new Course("Programming with C#");
            Course python101 = new Course("Programming in Python");
            bachelorsIt.AddCourse(cSharp101);
            bachelorsIt.AddCourse(python101);
            // A course 
            // has multiple teachers and students (which are of an abstract class person)
            Teacher mrsDoubtfire = new Teacher("mrs", "Doubtfire", 65);
            Teacher willyWonka = new Teacher("Willy", "Wonka", 43);
            cSharp101.AddTeacher(mrsDoubtfire);
            mrsDoubtfire.AddCourseTaught(cSharp101);
            cSharp101.AddTeacher(willyWonka);
            willyWonka.AddCourseTaught(cSharp101);
            Student henry = new Student("Henry", "The great", 21);
            Student melissa = new Student("Melissa", "Price", 20);

            universiteitUtrecht.PrintAllPrograms();
            mrsDoubtfire.Laugh();
            mrsDoubtfire.PrintAllCoursesTaught();
            melissa.Laugh();
        }
    }
}
