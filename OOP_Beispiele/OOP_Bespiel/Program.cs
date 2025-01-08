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

            Plane plane = new Plane();
            plane.Acceleration = 50;
            plane.DoorCount = 8;
            plane.BreakSpead = 200;
            plane.Speed = 750;
            plane.HasJetDrive = true;


            plane.LogInformation();
        }
    }
}
