using System;

namespace OOP_Bespiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Car car = new Car()
            {
                Acceleration = 100,
                DoorCount = 5,
                BreakSpead = 50,
                Speed = 220
            };
            car.LogInformation();

            Plane plane = new Plane()
            {
                Acceleration = 500,
                DoorCount = 8,
                BreakSpead = 200,
                Speed = 700,
                HasJetDrive = true
            };
            plane.LogInformation();
        }
    }
}
