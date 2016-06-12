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

            
            Student student1 = new Student("Name1", "Lastname", "Address1", "address2", 
                "City", "State", "Country", new DateTime());
            Student student2 = new Student("Name2", "Lastname", "Address1", "address2",
                "City", "State", "Country", new DateTime());
            Student student3 = new Student("Name3", "Lastname", "Address1", "address2",
                "City", "State", "Country", new DateTime());

            student1.Grades.Push(5);
            student1.Grades.Push(7);
            student1.Grades.Push(6);
            student1.Grades.Push(7);
            student1.Grades.Push(4);

            student1.Grades.Push(6);
            student1.Grades.Push(10);
            student1.Grades.Push(9);
            student1.Grades.Push(7);
            student1.Grades.Push(7);

            student1.Grades.Push(8);
            student1.Grades.Push(6);
            student1.Grades.Push(3);
            student1.Grades.Push(3);
            student1.Grades.Push(8);

            Course course1 = new Course("Programming with C#", 5, 5);
            
            course1.Students.Add(student1);
            course1.Students.Add(student2);
            course1.Students.Add(student3);

            course1.ListStudents();
        }
    }
}
