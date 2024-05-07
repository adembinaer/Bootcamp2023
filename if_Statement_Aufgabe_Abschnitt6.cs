using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Raetselspiel
{
    internal class if_Statement_Aufgabe_Abschnitt6
    {
        static void Main(string[] args)
        {

            //Aufgabe 1: Schreibe ein Programm das dich auffordert,
            //eine ganze Zahl einzugeben und dann mit if, else-if und else 
            //prüft und ausgibt, ob diese Zahl positiv, negativ oder null ist.

            //Console.WriteLine("Bitte geben Sie eine mathematisch Ganze Zahl ein");

            //int number = int.Parse(Console.ReadLine());

            //if(number > 0)
            //{
            //    Console.WriteLine("Ihre eingegeben Zahl ist positiv");
            //}
            //else if(number < 0)
            //{
            //    Console.WriteLine("Ihre eingegeben Zahl ist negativ");
            //}
            //else
            //{
            //    Console.WriteLine("Sie haben die Zahl 0 angegeben");
            //}


            //Aufgabe 2: Schreibe ein Programm das dich auffordert,
            //einen Benutzernamen und ein Passwort einzugeben
            //und dann überprüft, ob sowohl der Benutzername
            //als auch das Passwort korrekt sind

            string password = "HalloJanick2024";
            string userName = "Lerngut";

            Console.WriteLine("Bitte geben Sie Ihren Benutzer ein: ");
            string tryUsername = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie Ihr Passwort ein");
            string tryPassword = Console.ReadLine();

            if(tryUsername == userName && tryPassword == password)
            {
                Console.WriteLine("Benutzernamen und Passwort sind korrekt");
            }
            else
            {
                Console.WriteLine("Ihre Angaben sind falsch, entweder ist Ihr Benutzer oder das Passwort falsch");
            }
        }
    }
}
