using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abschnitt_15_IO_Files_Path
{
    public class Directory_Lession
    {
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
                Directory.CreateDirectory(path);
            }

            var filesInDir = Directory.GetFiles(path);
            
        
        }
    }
}
