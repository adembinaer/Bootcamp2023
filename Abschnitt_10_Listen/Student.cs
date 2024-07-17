using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abschnitt_10_Listen
{
    internal class Student
    {
        //Aufgabe: Erstelle ein Programm mit einer Lister von Studenten
        //Verwende für den Studenten eine Klasse
        //Jeder Student hat eine NC
        //Berechne dann den druchschnittlichen NC aller Studenten mit einer Schleife

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public float Nc { get; private set; }

        //List<string> studenten = new List<string>() { "Paul", "Jannick", "Quadrado" };
        List<Student> studentenList = new List<Student>();

        public Student(string firstName, string lastName, float nc)
        {
            FirstName = firstName;
            LastName = lastName;
            Nc = nc;
        }

        public void AddStudent(Student student)
        {
            studentenList.Add(student);// ADD methode only 1 Argument. NEED firstName, lastName, nc --->how???
        }

        public float AravangeStudentNc()
        {
            float totalGradeOfPoints = 0;
            foreach (Student student in studentenList)//LISTE von kontruktor in foreach!!!???
            {
                totalGradeOfPoints += student.Nc;
            }
            return totalGradeOfPoints / studentenList.Count;
        }
    }
}
