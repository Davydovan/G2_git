using System;
using System.Collections.Generic;

namespace University
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();
            Lectyrer lecture = new Lectyrer("Ivan", "Petrov", "maths");

            Student student1 = new Student("Svetlana", "Shalda", "maths", "PM-63");
            Student student2 = new Student("Merry", "Ivanova", "maths", "PM-64");
            Student student3 = new Student("Petr", "Shevchenko", "maths", "PM-65");
            Student student4 = new Student("Natalia", "Lilu", "physics", "LM-60");
            Student student5 = new Student("Katy", "Sergienko", "physics", "PM-66");
            Student student6 = new Student("Sasha", "Barulo", "maths", "KM-63");

            listStudents.Add(student1);
            listStudents.Add(student2);
            listStudents.Add(student3);
            listStudents.Add(student4);
            listStudents.Add(student5);
            listStudents.Add(student6);

            lecture.AddStudents(listStudents);
            lecture.DisplayListOfStudents();

            Console.ReadKey();


        }
    }
}
