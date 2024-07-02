using System;

namespace Abschnitt_8_Objektorientiert_Teil1
{
    class Program
    {
        static void Main(string[] args)
        {       

            Car myCar = new Car("Toyota","Supra 3000", 2000); //Eine Instanz = neues Objekt erstellen, initialisierung der Felder in Class Car oder mit Konstruktor direkt hier
            myCar.Honk(); //Methode in Class Car muss Public sein. Mit dem Punkt(.Honk()) greiffen wir auf die Felder, Properties, Methoden zu.
            string info = myCar.GetFullInfo();
            Console.WriteLine(info);

            float consumption = myCar.CalculateFuelConsumption(1148, 5.7f); //zweiter Argument ist der dynamische Wert der Methode, der ist momentan Null
            Console.WriteLine("Das Auto verbraucht " + consumption + " Liter Benzin");
        }
    }
}
