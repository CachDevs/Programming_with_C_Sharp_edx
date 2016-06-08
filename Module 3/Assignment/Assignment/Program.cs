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
            try
            {
                GetStudentInformation();
                GetTeacherInformation();
                GetCourseInformation();
                GetProgramInformation();
                GetDegreeInformation();
                validateBirthday();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday (dd/MM/yyyy)");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday.ToShortDateString());
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday (dd/MM/yyyy)");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            PrintTeacherDetails(firstName, lastName, birthday);
        }

        static void PrintTeacherDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday.ToShortDateString());
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the course's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course's theme");
            string theme = Console.ReadLine();
            Console.WriteLine("Enter the course's start date (dd/MM/yyyy)");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());

            PrintCourseDetails(name, theme, startDate);
        }

        static void PrintCourseDetails(string name, string theme, DateTime startDate)
        {
            Console.WriteLine("{0} is about {1} and starts {2}", name, theme, startDate.ToShortDateString());
        }

        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the program's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the program's theme");
            string theme = Console.ReadLine();
            Console.WriteLine("Enter the program's creation date (dd/MM/yyyy)");
            DateTime creationDate = Convert.ToDateTime(Console.ReadLine());

            PrintProgramDetails(name, theme, creationDate);
        }

        static void PrintProgramDetails(string name, string theme, DateTime startDate)
        {
            Console.WriteLine("{0} is about {1} and was made {2}", name, theme, startDate.ToShortDateString());
        }

        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the degree's theme");
            string theme = Console.ReadLine();
            Console.WriteLine("Enter the degree's start date (dd/MM/yyyy)");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());

            PrintDegreeDetails(name, theme, startDate);
        }

        static void PrintDegreeDetails(string name, string theme, DateTime startDate)
        {
            Console.WriteLine("{0} is about {1} and starts {2}", name, theme, startDate.ToShortDateString());
        }

        static void validateBirthday()
        {
            throw new NotImplementedException();
        }
    }
}
