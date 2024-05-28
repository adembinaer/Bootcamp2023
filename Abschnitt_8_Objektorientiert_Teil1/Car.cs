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
        string brand = "Toyota";
        string model = "XYZ";
        int year = 2004;

        public void Honk()
        {
            Console.WriteLine("Das Auto hupt!");
        }
    }
}
