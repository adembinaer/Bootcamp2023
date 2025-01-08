using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bespiel
{
    class Motorcycle : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Zwei Räder haben Bodenkontakt.");
        }
    }
}
