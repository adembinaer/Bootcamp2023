using System;
using System.Collections.Generic;

namespace Abschnitt_10_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Übung Teil 1

            //int[] numbers = new int[3] { 1, 2, 3 }; //Vergleichen Array vs List

            //List<int> ints = new List<int>();
            //// Hizufügen
            //ints.Add(100);
            //ints.Add(-100);
            //ints.Add(500);

            //// Entferne. Die Liste sucht den Wert den man Removen möchte!!! Wert 100 ist ein objektinstanz und ist ein Item kein Index
            //ints.Remove(100);//BOOL

            //// Clear, alle Elemente auf einmal.
            //ints.Clear(); //VOID

            //// Einfügen am Index
            //ints.Insert(1, 500);

            //// Löschen am Index, nur Index angeben.
            //ints.RemoveAt(1);

            //// Index holen
            //int index = ints.IndexOf(100);// Holt dir den Index wo der Wert im Index hinterlegt ist.

            //// Count
            //int count = ints.Count; // Count ist ein Propertie. Wieviele Elemente in der Liste



            //Übung Teil 2
            //List<string> names = new List<string>() { "Jannick", "Ado", "Welli" };

            //Console.WriteLine(names[1]);

            //names.Add("Maria");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //names[1] = "Peter";


            //// Beispiel 1 Aufgabe NC berechnen
            //List<Student> students = new List<Student>();
            ////Practis_Studenten_NC_berechnen_Part1 studentOne = new Practis_Studenten_NC_berechnen_Part1("Jannick", "Leinsmann", 2);
            ////students.Add(studentOne);

            ////Beispiel 2
            //students.Add(new Student("Jannick", "Leismann", 2.6f));
            //students.Add(new Student("Peter", "Müller", 1.8f));
            //students.Add(new Student("Debora", "Krissler", 2.2f));

            //float totalGradePoints = 0;

            //foreach (Student student in students)
            //{
            //    totalGradePoints += student.Nc;
            //}

            //float averageGradePoint = totalGradePoints / students.Count;
            //Console.WriteLine("Der durchschnittliche Notenschnitt ist: " + averageGradePoint);





            // Eigene Lösung



            float totalGradeOfPoints = 0;
            while (true)
            {



                Console.WriteLine("Was möchten sie tun?");
                Console.WriteLine("1. Studenten eingeben");
                Console.WriteLine("2. Studentenanzahl erreicht, NC-Durchschnitt wird berechnet");
                Console.WriteLine("3. Programm beenden");
                string input = Console.ReadLine();


                List<Student> studentenList = new List<Student>();
                studentenList.Add(new Student("aaaaaaa", "bbbbbbbbb", 4f));
                studentenList.Add(new Student("ccccccc", "dddddddd", 3f));
                studentenList.Add(new Student("eeeeeee", "ffffffff", 2f));
                studentenList.Add(new Student("ggggggg", "hhhhhhhh", 1f));

                if (input == "1")
                {
                    Console.WriteLine("Bitte Geben Sie den Vornamen ein");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Bitte Geben Sie den Nachnamen ein");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Bitte geben Sie ihren Notendurchschnitt ein");
                    float nc = float.Parse(Console.ReadLine());



                    Student studenten = new Student(firstName, lastName, nc);



                    for (int i = 0; i < studentenList.Count; i++)
                    {

                    }

                    foreach (Student student in studentenList)//LISTE von kontruktor in foreach!!!???
                    {
                        totalGradeOfPoints += student.Nc;
                    }
                    Console.WriteLine("Der Notendurchschnitt ergibt: " + studenten.AravangeStudentNc(totalGradeOfPoints, studentenList.Count) + "\n");
                    //if (input == "2")
                    //{


                    //}

                    //studentenList.Add($"{firstName} {lastName} {nc}"); //Als Info für Add mit ${}

                }
                //else if (input == "2")
                //{
                //    float averageGradePoint2 = totalGradeOfPoints / studentenList.Count;
                //    Console.WriteLine("Der durchschnittliche Notenschnitt ist: " + averageGradePoint2 + "\n");

                //}
                if (input == "3")
                {
                    break;
                }




            }
        }
    }
}
