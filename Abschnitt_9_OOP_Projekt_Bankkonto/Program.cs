using System;

namespace Abschnitt_9_OOP_Projekt_Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(
                "201508",
                "Ado J",
                500);

            while (true)
            {
                Console.WriteLine("Was möchten Sie tun?");
                Console.WriteLine("1: Kontostand anzeigen");
                Console.WriteLine("2: Einzahlung machen");
                Console.WriteLine("3: Auszahlung machen");
                Console.WriteLine("4: Beenden");
                string input = Console.ReadLine();

                if(input == "1")
                {

                }
                else if (input == "2")
                {

                }
                else if (input == "3")
                {

                }
                else if (input == "4")
                {
                    break; // Return?
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl, bitte versuchen Sie es nochmals");
                }
            }
        }
    }
}
