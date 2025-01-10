using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Bespiel
{
    class Helicopter : Plane
    {
        //Man muss nicht von Interface erben
        public bool HasRotoren { get; set; }
        //public override void Move()
        //{
        //    Console.WriteLine("Die Räder am Boden stehen still und haben Bodenkontakt.\nDie Räder in der Luft sind ausgeklappt.");
        //}
        public override void Landing()
        {
            //base.Landing(); //Auskommentieren damit er in der Console nicht angezeigt wird
            Console.WriteLine("Der Helikopter sinkt senkrecht langsam");
        }
    }
}
