using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Course
    {
        private string courseName;
        private int credits, durationInWeeks;
        Teacher[] teachers;
        List<Student> students = new List<Student>();

        #region properties

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public int DurationInWeeks
        {
            get
            {
                return durationInWeeks;
            }

            set
            {
                durationInWeeks = value;
            }
        }

        internal Teacher[] Teachers
        {
            get
            {
                return teachers;
            }
        }

        public ArrayList Students
        {
            get
            {
                return students;
            }
        }



        #endregion

        public Course(string courseName, int credits, int durationInWeeks, Teacher teacher1 = null,
            Teacher teacher2 = null, Teacher teacher3 = null, Student student1 = null,
            Student student2 = null, Student student3 = null)
        {
            CourseName = courseName;
            Credits = credits;
            DurationInWeeks = durationInWeeks;

            Teacher[] t = { teacher1, teacher2, teacher3 };
            teachers = t;

            if (student1 != null)
                Students.Add(student1);
            if (student2 != null)
                Students.Add(student2);
            if (student3 != null)
                Students.Add(student3);
        }

        public void addTeacher(Teacher t)
        {
            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i] == null) { teachers[i] = t; }
                break;
            }
        }

        public void ListStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
        
    }
}
