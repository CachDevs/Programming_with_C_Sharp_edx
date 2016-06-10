using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Student
    {
        private string firstName, lastName, addressLine1, addressLine2, city, state, country;
        private DateTime birthdate;
        private static int numberOfStudents;

        #region properties

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        #endregion

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

        public static int getStudents()
        {
            return numberOfStudents;
        }
    }
}
