using System;

namespace Abschnitt_13_Switch_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Enums Übung. Vorteil, man kann via Casting direkt auf das Enum zugreifen und sieht dann den Value vom Enum und nicht irgendwelche Magic Numbers

            //Resolutions myResolution = Resolutions.UHD;

            //myResolution = (Resolutions)720;

            //Console.WriteLine(myResolution);
            ////Übung fertig

            Console.WriteLine("Wählen Sie eine Auflösung (720, 1920, 3840)");

            int resolution = int.Parse(Console.ReadLine());

            Resolutions myResolution = (Resolutions)resolution;

            switch (myResolution)
            {
                case Resolutions.SD:
                    Console.WriteLine("Standard");
                    break;
                case Resolutions.HD:
                    Console.WriteLine("High Definition");
                    break;
                case Resolutions.UHD:
                    Console.WriteLine("Ultra High Definition");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }
        }
    }
}
