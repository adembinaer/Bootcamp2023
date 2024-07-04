using System;

namespace Abschnitt_9_OOP_Projekt_Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte erstellen Sie ein Bankkonto und gehen Schritt für Schritt vor, beginnend mit 1. !");
            Console.WriteLine("1. Kontonummer");
            string inputAccount = Console.ReadLine();
            Console.WriteLine("2. Vorname Name");
            string inputFirstLastName = Console.ReadLine();
            Console.WriteLine("3. Kontostand");
            float initialBalance = float.Parse(Console.ReadLine());
   

            BankAccount bankAccount = new BankAccount(
                inputAccount, 
                inputFirstLastName, 
                initialBalance);

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
                    bankAccount.PrintBalance();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie einzahlen möchten: ");
                    float depositAmount = float.Parse(Console.ReadLine()) ;
                    bankAccount.MakeDeposit(depositAmount);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie abheben möchten: ");
                    float withdrawalAmount = float.Parse(Console.ReadLine());
                    bankAccount.MakeWithdrawal(withdrawalAmount);             
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
