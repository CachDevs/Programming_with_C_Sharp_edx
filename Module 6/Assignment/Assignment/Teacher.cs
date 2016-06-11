using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Teacher : Person
    {

        public Teacher(string firstName, string lastName, string addresLine1,
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
        }

        public void GradeTest() { Console.WriteLine("Grading test..."); }
    }
}
