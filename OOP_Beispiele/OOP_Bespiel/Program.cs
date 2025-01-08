using System;
using System.Collections.Generic;

namespace OOP_Bespiel
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car()
            {
                Acceleration = 100,
                DoorCount = 5,
                BreakSpead = 50,
                Speed = 220
            };
            //car.LogInformation();
            //car.Move();

            Plane plane = new Plane();
            plane.Acceleration = 50;
            plane.DoorCount = 8;
            plane.BreakSpead = 200;
            plane.Speed = 750;
            plane.HasJetDrive = true;

            //plane.LogInformation();
            //plane.Move();

            Motorcycle motorcycle = new Motorcycle()
            {
                Acceleration = 200,
                DoorCount = 0,
                BreakSpead = 35,
                Speed = 340
            };
            //motorcycle.Move();
            //motorcycle.LogInformation();
            vehicles.Add(car);
            vehicles.Add(plane);
            vehicles.Add(motorcycle);

            Console.WriteLine($"Welches Fahrzeug möchtest du fahren(Car{0}, Plane{1}, Motorcycle{2})");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput == 0)
            {
                car.LogInformation();
                car.Move();
            }
            if(userInput == 1)
            {
                plane.LogInformation();
                plane.Move();
            }
            if(userInput == 2)
            {
                motorcycle.LogInformation();
                motorcycle.Move();
            }

            Console.WriteLine("Wir wünschen Ihnen eine gute Fahrt");
        }
    }
}
