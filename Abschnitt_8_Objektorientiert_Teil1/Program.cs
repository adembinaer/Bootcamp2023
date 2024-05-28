using System;

namespace Abschnitt_8_Objektorientiert_Teil1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car myCar = new Car();
            myCar.Honk(); //Methode in Class Car muss Public sein
        }
    }
}
