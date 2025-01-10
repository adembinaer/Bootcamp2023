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

            Helicopter helicpoter = new Helicopter()
            {
                Acceleration = 30,
                DoorCount = 4,
                BreakSpead = 300,
                Speed = 500,
                HasRotoren = true
            };

            vehicles.Add(car);
            vehicles.Add(plane);
            vehicles.Add(motorcycle);
            vehicles.Add(helicpoter);


            Console.WriteLine("Welches Fahrzeug möchtest du fahren(Car, Plane, Motorcycle, Helicopter)");
            var userInput = (Console.ReadLine());

            foreach (Vehicle vehicle in vehicles) //break; in Schleife nicht vergessen
            {
                //if(vehicle.GetType().Name == userInput) //GetType typ von Klasse. Mit NAME wollen wir nur den Klassenamen erhalten
                //{
                //    Console.WriteLine("Fahrzeug gefunden: " + userInput + " .Wir wünschen Ihnen eine gute Fahrt");
                //    //break;
                //}

                if (vehicle.GetType().Name == userInput) //GetType typ von Klasse. Mit NAME wollen wir nur den Klassenamen erhalten
                {
                    Console.WriteLine("Fahrzeug gefunden: " + userInput + " .Wir wünschen Ihnen eine angenehme Reise");
                    vehicle.LogInformation();

                    if (userInput == "Car")
                    {
                        Car myCar = vehicle as Car; //Typumwandeln von Baseclass in die Classe wo man das Objekt braucht.
                        myCar.Move();
                    }
                    else if (userInput == "Plane")
                    {
                        Plane myPlane = vehicle as Plane;
                        myPlane.Move();
                        myPlane.Landing();
                    }
                    else if (userInput == "Motorcycle")
                    {
                        Motorcycle myMotorcycle = vehicle as Motorcycle;
                        myMotorcycle.Move();
                    }
                    else if (userInput == nameof(Helicopter)) // Mit Nameof macht man weniger Tippfehler wegen Stringeingabe
                    {
                        Helicopter myHelicopter = vehicle as Helicopter;
                        myHelicopter.Move();
                        myHelicopter.Landing();
                    }
                }
            }

            ////Beispiel mit Variabel
            //Console.WriteLine($"Welches Fahrzeug möchtest du fahren(Car {0}, Plane {1}, Motorcycle {2})");
            //var userInput = int.Parse(Console.ReadLine());

            //if(userInput == 0)
            //{
            //    car.LogInformation();
            //    car.Move();
            //}
            //if(userInput == 1)
            //{
            //    plane.LogInformation();
            //    plane.Move();
            //}
            //if(userInput == 2)
            //{
            //    motorcycle.LogInformation();
            //    motorcycle.Move();
            //}

            //Console.WriteLine("Wir wünschen Ihnen eine gute Fahrt");
        }
    }
}
