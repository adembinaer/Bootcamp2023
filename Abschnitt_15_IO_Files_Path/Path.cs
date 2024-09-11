using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Abschnitt_15_IO_Files_Path
{
    public class Path
    {
        string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Bespiel

        string path = "files/"; // Mit combine kann man files(/) weglassen. combine erzeugt diese selber wenn es mehrer Pfade bis zum Ziel gibt
        string fileName = "text.txt";

        //public void GetPath()
        //{
        //    string finalPath = Path.Combine(path, fileName); //Combine gibt hier Fehler, Framework? . Combine gib den richtige Orderpfad an


        //}

        public void GetPathInDetail() //Nur mp3 dateien auslesen lassen vom Desktop Ordner files
        {
            string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/files"; //Order muss auf Desktop erstellte werden

            string[] files = Directory.GetFiles(path3);
            
            for (int i = 0; i > files.Length; i++)
            {
                Console.WriteLine(files[i]); // das oder das untere ausführen lassen
                //var ext = Path.GetExtension(files[i]); //Framework out of support? Extension = die Dateiendung erhalten
                //Console.WriteLine(ext);

                if( ext == ".mp3") { } // Beispiel


            }

            // Anzeigen lassen ohne text.txt, nur mp3 files
            for (int i = 0; i > files.Length; i++)
            {
             
                //var ext = Path.GetFileNameWithoutExtension(files[i]); //Framework out of support?
                //Console.WriteLine(ext);


            }
        }
    }
}
