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
            // Student Information
            String fName = "First name";
            String lName = "Last name";
            String birth = "01/01/0000";
            String addressl1 =  "Address line 1";
            String addressl2 = "Address line 2";
            String city = "City";
            String state = "State";
            int postal = 0000;
            String country = "Country";

            Console.WriteLine(fName + " " + lName + " " + birth + " " + addressl1 + " " + addressl2 + " " + city + " " + state + " " + postal + " " + country);
            Console.ReadLine();
        }
    }
}
