using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student : Person
    {
        private static int numberOfStudents;
        Stack<int> grades = new Stack<int>();

        public Student(string firstName, string lastName, string addresLine1,
            string addressLine2, string city, string state, string country, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            AddressLine1 = addresLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            Country = country;
            Birthdate = birthdate;
            numberOfStudents++;
        }

        public Stack<int> Grades
        {
            get
            {
                return grades;
            }
        }

        public static int getStudents()
        {
            return numberOfStudents;
        }

        public void TakeTest() { Console.WriteLine("Taking test..."); }
    }
}
