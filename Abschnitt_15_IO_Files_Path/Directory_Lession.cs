using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abschnitt_15_IO_Files_Path
{
    public class Directory_Lession
    {
        string path3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/files"; // zum Beispiel
        string path2 = @"C:\Users\Files\files"; // zum Beispiel

        string path = "files/";
        string fileName = "text.txt";

        public void DirectoryPath()
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine("Ordner existiert ");
            }
            else
            {
                Directory.CreateDirectory(path); // Ordner files/ erstellen
            }

            //Get Files
            var filesInDir = Directory.GetFiles(path); // Zeigt die Dateien im Order files auf
            //Console.WriteLine(filesInDir);
            for (int i = 0; i < filesInDir.Length; i++)
            {
                Console.WriteLine(filesInDir[i]);
            }

            //Get Directories
            var dirsInDir = Directory.GetDirectories(path); // Zeigt die Unterordner im filesordner auf
            //Console.WriteLine(dirsInDir);
            for (int i = 0; i < dirsInDir.Length; i++)
            {
                Console.WriteLine(dirsInDir[i]);
            }

            var currentPath = Directory.GetCurrentDirectory(); // Zeigt das momentane Verzeichnis/Ordner auf den Pfad c://....
            Console.WriteLine(currentPath);

        }
    }
}
