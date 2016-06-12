using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Degree
    {
        private string degreeName;
        private int creditsRequired;
        private Course[] courses;

        #region properties

        public string DegreeName
        {
            get
            {
                return degreeName;
            }

            set
            {
                degreeName = value;
            }
        }

        public int CreditsRequired
        {
            get
            {
                return creditsRequired;
            }

            set
            {
                creditsRequired = value;
            }
        }

        internal Course[] Courses
        {
            get
            {
                return courses;
            }
        }

        #endregion

        public Degree(string degreeName, int creditsRquired, Course course1 = null,
            Course course2 = null, Course course3 = null)
        {
            DegreeName = degreeName;
            CreditsRequired = creditsRquired;
            
            Course[] c = { course1, course2, course3 };
            courses = c;
            
        }

        public void addCourse(Course c)
        {
            for (int i = 0; i < courses.Length; i++)
            {
                if (courses[i] == null) { courses[i] = c; }
                break;
            }
        }
    }
}
