using System;
using System.Collections.Generic;
using System.Text;

namespace Abschnnitt_12_Dictionary
{
    public class Lession_Part
    {
        public void LessionOne()
        {
            // Dictionaries

            // English | Deutsch
            // Cart | Warenkorb
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Cart", "Warenkorb");
            dic.Remove("Cart");

            // Produkt | Preis
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Remove("Milch");

            // ID | Person (Objekt)
            // 50 | Objekt maybe Property "Jannick"
            Dictionary<int, Person> people = new Dictionary<int, Person>();
            people.Add(50, new Person());
            people.Remove(50);

            people.Clear();
        }
    }
    public class Person
    {
        // Properties ID und Name ??? 
    }
}


