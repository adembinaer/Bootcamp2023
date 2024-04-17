using System;

namespace Udemy_Bootcamp2023_Jannick_Leismann
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 3;

            int userGuess = 0;

            while(userGuess != secretNumber)
            {
                Console.WriteLine("Ein Zahlenrätselspiel bis 10. Stellen Sie Ihre Vermutung: ");
                userGuess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Das war korrekt");
        }
    }
}
