using System;
using System.Collections.Generic;

namespace Abschnitt_14_Erweiterte_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested Loops verschachtelte Schleifen 

            // Datenquelle
            List<Product> products = new List<Product>();
            products.Add(new Product("Bratpfanne", new List<int> { 3,5,4 }));//{3,1,2} Sind Sternebewertungen der Konsumenten als Beispiel
            products.Add(new Product("Toaster", new List<int> { 4,1,5 }));
            products.Add(new Product("Wasserkocher", new List<int> { 5,2,1,4 }));
            products.Add(new Product("Stabmixer", new List<int> { 3,2 }));

            // Durchlaufen aller Produkte im Foreach
            //foreach (Product product in products) // <- outer loop
            //{
            //    Console.WriteLine("Produkt: " + product.Name);

            //    foreach (int rating in product.Ratings) // <- inner loop
            //    {
            //        Console.WriteLine($"{rating} * für das Produkt {product.Name}");
            //    }
            //}

            // Beispiel mit FOR-Loop WICHTIG es wird immer mit Index gearbeitet, daher products[INDEX].Name ect
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("Produkt: " + products[i].Name);

                if (products[i].Name == "Toaster")//Übung Continue. Continue beendet sofort Schleifeniteration ab und sprint auf die outer loop
                {
                    continue;
                }

                for (int r = 0; r < products[i].Ratings.Count; r++)
                {
                    Console.WriteLine($"{products[i].Ratings[r]} + * für das Produkt + {products[i].Name}");
                    if( products[i].Ratings[r] == 1) //Übung Break. Beendet/bricht komplette Schleife
                    {
                        Console.WriteLine("Diese Produkt ist schlecht");
                        break;  
                    }
                }
            }

        }
        internal class Product
        {
            public string Name { get; private set; }

            public List<int> Ratings { get; private set; }

            public Product(string name, List<int> ratings)
            {
                Name = name;
                Ratings = ratings;
            }

        }

    }
}
