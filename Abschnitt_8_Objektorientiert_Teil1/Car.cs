using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschnitt_8_Objektorientiert_Teil1
{
    internal class Car
    {
        // Standart private -> exces(zugriff) modifer(modifiziere) privat, public , internal

        //Diese drei Felder sind initialisiert
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }


        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public void Honk()
        {
            Console.WriteLine("Das Auto hupt!");
        }

        public string GetFullInfo()
        {         
            return  $"{Brand} {Model} {Year}";
        }

        public float CalculateFuelConsumption(int kilometers, float consumptionRate) //Entwicklerwissen! Der Parameter die wir brauchen ist kilometers hardcodiert und somit der Returnwert.
                                                              //Was will der User, also Verbrauch per KM wissen. Dynamisch macht man es mit float consumptionRate
        {
            float consumptionPerKm = 8.0f / 100; //8.0f ersetzen mit consumptionRate Dynamisch
            return kilometers * consumptionPerKm;
        }
    }
}
