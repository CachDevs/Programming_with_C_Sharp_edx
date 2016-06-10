using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1
            Student student1 = new Student("Name1", "Lastname", "Address1", "address2", 
                "City", "State", "Country", new DateTime());
            Student student2 = new Student("Name2", "Lastname", "Address1", "address2",
                "City", "State", "Country", new DateTime());
            Student student3 = new Student("Name3", "Lastname", "Address1", "address2",
                "City", "State", "Country", new DateTime());

            // 2
            Course course1 = new Course("Programming with C#", 5, 5);

            // 3
            course1.addStudent(student1);
            course1.addStudent(student2);
            course1.addStudent(student3);

            // 4
            Teacher teacher1 = new Teacher("Teacher1", "Lastname", "Address1", "address2", 
                "City", "State", "Country", new DateTime());

            // 5
            course1.addTeacher(teacher1);

            // 6
            Degree degree1 = new Degree("Bachelor", 5);

            // 7
            degree1.addCourse(course1);

            // 8
            UProgram program1 = new UProgram("Information Technology", "Head");

            // 9
            program1.addDegree(degree1);

            // 10
            // 10.1
            Console.WriteLine("The {0} program contains the {1} degree", 
                program1.ProgramName, program1.Degrees[0].DegreeName);

            // 10.2
            Console.WriteLine("The {0} degree contains the course {1}",
                degree1.DegreeName, degree1.Courses[0].CourseName);

            // 10.3
            Console.WriteLine("The {0} course contains {1} students",
                course1.CourseName, Student.getStudents());
            
        }
    }
}
