using System;
using System.IO; // Input/Output

namespace Abschnitt_15_IO_Files_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = "test.txt";

            //// Create File
            //File.Create(path);

            // Read File
            //string content = File.ReadAllText(path);
            //Console.WriteLine(content);

            // Copy File

            //if (File.Exists(path))
            //{
            //    string destpath = "testCopy.txt";
            //    File.Copy(path, destpath);
            //}
            //else
            //{
            //    Console.WriteLine("Can not find file");

            //    FileStream fs = File.Create(path);
            //    fs.Close();

            //    Console.WriteLine("Created file");
            //    File.WriteAllText(path, "Hoi zämme"); //File-Inhalt ändern   
            //}

            // Append -> vorhandenen Text anfügen
            //if (File.Exists(path))
            //{
            //    File.AppendAllText(path, "DUUUUU NO NO NO");
            //}

            // Delete
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File deleted");
            //    File.Delete(path);
            //}


            // Übung Ordner class Directory
            Directory_Lession diractoryMethod = new Directory_Lession();
            Console.WriteLine(diractoryMethod.DirectoryPath());
        }
    }
}

