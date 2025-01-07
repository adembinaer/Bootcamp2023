using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string logPath = "log.txt";
            string fileName = "test.txt";
            string path = "folder/folder2/"; //invalid ohne 1./ sieht man den ganzen path

            try
            {
                string finalPath = Path.Combine(path + fileName);
                File.Create(finalPath);
                File.AppendAllText(finalPath, "Hallo Welt");
                //File.Create(path);//ohne Directory.Create.... gibts hier einen Fehler, da der Path nicht gefunden werden kann.
                File.AppendAllText(logPath, "Log: Successfully \n");
            }
            //catch (IOException e)
            //{
            //    File.AppendAllText(logPath, "Log: File already in use" + e + "\n");
            //}
            catch (Exception e)
            {
                //Directory.CreateDirectory(path);
                //File.AppendAllText(logPath, "Log: Somethings went wrong. Exception: " + e + "\n");

                throw;
                //THROW; Bei heiklen Daten die evtl nicht bearbeitet werden sollen. So beendete man den Catchblock mit einem throw(wirf ein Excep aus).
                //Als CW könnte man dem User angeben, dass er keine Berechtigung hat und das Prg schliesst sich.
            }

            File.AppendAllText(logPath, "Log: Tried to create file. \n");
        }
    }
}
