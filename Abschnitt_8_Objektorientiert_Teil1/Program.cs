using System;

namespace Abschnitt_8_Objektorientiert_Teil1
{
    class Program
    {
        static void Main(string[] args)
        {       

            Car myCar = new Car("Toyota","Supra 3000", 2000); //Eine Instanz = neues Objekt erstellen, initialisierung der Felder in Class Car oder mit Konstruktor direkt hier
            myCar.Honk(); //Methode in Class Car muss Public sein. Mit dem Punkt(.Honk()) greiffen wir auf die Felder, Properties, Methoden zu.
            Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Model);
            Console.WriteLine("Baujahr " + myCar.Year);
        }
    }
}
