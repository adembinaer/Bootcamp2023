using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Raetselspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int[] numbers = new int[5];
            int input = 0;
            int resultArray = 0;

            Console.WriteLine("Sie werden mehrmals eine Zahl eingeben müssen \n");

            while (index < numbers.Length)
            {
                Console.WriteLine("Bite gib die " + (index + 1) + " Zahl ein: ");

                input = int.Parse(Console.ReadLine());

                numbers[index] = input;

                resultArray += input;

                index++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Das Resultat Ihrer Eingabe: " + resultArray);
        }
    }
}
