#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRigth = new Point(1366, 768);
            Console.WriteLine(Point.ObjectCount());
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
