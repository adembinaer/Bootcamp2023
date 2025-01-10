using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bespiel
{
    abstract class Vehicle
    {
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public float BreakSpead { get; set; }

        public int DoorCount { get; set; }

        public void LogInformation()
        {
            Console.WriteLine("Das Fahrzeug fährt mit " + Speed + "Km/h.");
        }
    }
}
