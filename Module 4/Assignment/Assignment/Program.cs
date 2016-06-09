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
            Student[] students = new Student[5];

            students[0].Name = "Name";
            students[0].LastName = "Lastname";
            students[0].birthdate = new DateTime();

            Console.WriteLine(students[0].Name);
            Console.WriteLine(students[0].LastName);
            Console.WriteLine(students[0].birthdate);
        }

        public struct Student
        {
            public Student(String name, String lastname, DateTime birthdate) {
                this.Name = name;
                this.LastName = lastname;
                this.birthdate = birthdate;
            }

            public String Name, LastName;
            public DateTime birthdate;
        }

        public struct Teacher
        {
            public Teacher(String name, String lastname, DateTime birthdate)
            {
                this.Name = name;
                this.LastName = lastname;
                this.birthdate = birthdate;
            }
            public String Name, LastName;
            public DateTime birthdate;
        }

        public struct UProgram
        {
            public UProgram(String name, String developer, DateTime release)
            {
                this.Name = name;
                this.Developer = developer;
                this.releaseDate = release;
            }
            public String Name, Developer;
            public DateTime releaseDate;
        }

        public struct Course
        {
            public Course(String name, String theme, DateTime start)
            {
                this.Name = name;
                this.Theme = theme;
                this.startDate = start;
            }
            public String Name, Theme;
            public DateTime startDate;
        }
    }
}
