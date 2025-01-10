using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bespiel
{
    class Plane : Vehicle, IVehicle
    {
        public bool HasJetDrive { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Die Räder am Boden sind rollbereit und haben Bodenkontakt.\nDie Räder in der Luft sind eingeklappt.");
        }

        public virtual void Landing()
        {
            Console.WriteLine("Landeanflug beginnt mit Passagieren");
        }
    }
}
