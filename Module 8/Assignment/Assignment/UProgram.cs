using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class UProgram
    {
        private string programName, departmentHead;
        private Degree[] degrees;

        #region properties

        public string ProgramName
        {
            get
            {
                return programName;
            }

            set
            {
                programName = value;
            }
        }

        public string DepartmentHead
        {
            get
            {
                return departmentHead;
            }

            set
            {
                departmentHead = value;
            }
        }

        internal Degree[] Degrees
        {
            get
            {
                return degrees;
            }
        }

        #endregion

        public UProgram(string programName, string departmentHead, Degree degree1 = null, 
            Degree degree2 = null, Degree degree3 = null)
        {
            ProgramName = programName;
            DepartmentHead = departmentHead;

            Degree[] d = { degree1, degree2, degree3 };
            degrees = d;
            
        }

        public void addDegree(Degree d)
        {
            for (int i = 0; i < degrees.Length; i++)
            {
                if (degrees[i] == null) { degrees[i] = d; }
                break;
            }
        }

    }
}
