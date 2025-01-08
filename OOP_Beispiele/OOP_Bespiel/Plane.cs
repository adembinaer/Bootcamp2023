using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bespiel
{
    class Plane : Vehicle, IVehicle
    {
        public bool HasJetDrive { get; set; }

        public void Move()
        {
            Console.WriteLine("Die Räder am Boden sind rollbereit und haben Bodenkontakt.\n Die Räder in der Luft sind eingeklappt.");
        }
    }
}
