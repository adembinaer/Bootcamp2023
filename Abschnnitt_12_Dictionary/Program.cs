using System;
using System.Collections.Generic;

namespace Abschnnitt_12_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Produkt | Preis
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Add("Brot", 2.99f);
            products.Add("Banane", 2.49f);

            //products["Milch"] = 4.99f; //Neuer Wert für Milch
            Console.WriteLine(products["Milch"]);

            //Beispiel. Beim Iterieren ist KEY immer O(1) aber Value kann O(n) sein!!!
            foreach(KeyValuePair<string, float> product in products)
            {
                Console.WriteLine(product.Key + " " + product.Value);
            }

            //Dictionaries überprüfen
            if (products.ContainsKey("Milch"))
            {

            }
            if (products.ContainsValue(1.55f)) //True or False
            {

            }

            //2 Varianten um out zu definieren. Wichtig Scope beachten.

            //float price; 
            if (products.TryGetValue("Brot", out float price)) // Ist bool und gibt ein out aus im Parameter.
            {
                //Wert gefunden
            }
            else
            {
                // Key nicht gefunden
            }


        }
    }
}
