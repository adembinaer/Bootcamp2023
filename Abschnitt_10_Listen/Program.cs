using System;
using System.Collections.Generic;

namespace Abschnitt_10_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 1, 2, 3 }; //Vergleichen Array vs List

            List<int> ints = new List<int>();
            // Hizufügen
            ints.Add(100);
            ints.Add(-100);
            ints.Add(500);

            // Entferne. Die Liste sucht den Wert den man Removen möchte!!! Wert 100 ist ein objektinstanz und ist ein Item kein Index
            ints.Remove(100);//BOOL

            // Clear, alle Elemente auf einmal.
            ints.Clear(); //VOID

            // Einfügen am Index
            ints.Insert(1, 500);

            // Löschen am Index, nur Index angeben.
            ints.RemoveAt(1);

            // Index holen
            int index = ints.IndexOf(100);// Holt dir den Index wo der Wert im Index hinterlegt ist.

            // Count
            int count = ints.Count; // Count ist ein Propertie. Wieviele Elemente in der Liste


        }
    }
}
