using System;

namespace Abschnitt_8_Objektorientiert_Teil1
{
    class Program
    {
        static void Main(string[] args)
        {       

            Car myCar = new Car(); //Eine Instanz = neues Objekt erstellen, initialisierung der Felder in Class Car
            myCar.Honk(); //Methode in Class Car muss Public sein. Mit dem Punkt(.Honk()) greiffen wir auf die Felder, Properties, Methoden zu.
        }
    }
}
