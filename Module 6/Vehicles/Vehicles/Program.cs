using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane");
            Airplane myAirplane = new Airplane();
            myAirplane.StartEngine("Contact");
            myAirplane.TakeOff();
            myAirplane.Drive();
            myAirplane.Land();
            myAirplane.StopEngine("Whirr");

            Console.WriteLine("\nJourney by car");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("\nTesting polymorphsm");
            Vehicles v = myCar;
            v.Drive();
            v = myAirplane;
            v.Drive();
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
