using System;
using System.Collections.Generic;

namespace University
{
    abstract class BasicClass
    {
        public string name;
        public string surName;
        public string specialization;
        
        public BasicClass(string name, string surName, string specialization)
        {
            this.name = name;
            this.surName = surName;
            this.specialization = specialization;
        }
    }

    class Student:BasicClass
    {
        public string group;

        public Student(string name, string surName, string specialization, string group):base( name, surName, specialization)
        {           
            this.group = group;
        }
    }

    class Lecture:BasicClass
    {
        private List<Student> listStudentInGroup;

        public Lecture(string name, string surName, string specialization) : base(name, surName, specialization)
        {
            listStudentInGroup = new List<Student>();
        }

        public void AddStudents(List<Student> listStudent)
        {
            if (listStudent.Count < 5)
            {
                Console.WriteLine("Must have at least 5 students");
                return;
            }

            foreach (var item in listStudent)
            {
                if (item.specialization == specialization)
                {
                    listStudentInGroup.Add(item);
                }
                else 
                {
                    Console.WriteLine($"Spezialization {item.name}");
                    //continue;
                }
            }

                
        }

        public void DisplayListOfStudents()
        {

            foreach (var item in listStudentInGroup)
            {
                Console.Write(item.name);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            List<Student> listStudent = new List<Student>();
            Lecture lecture = new Lecture("Ivan", "Petrov", "K");
            Student student1 = new Student("F", "B", "K", "PM-1");
            Student student2 = new Student("FA", "BG", "K", "PM-1");
            Student student3 = new Student("FV", "BH", "K", "PM-3");
            Student student4 = new Student("FB", "BN", "N", "PM-1");
            Student student5 = new Student("FN", "BV", "K", "PM-4");
            Student student6 = new Student("FB", "BV", "K", "PM-1");
            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);
            listStudent.Add(student5);
            listStudent.Add(student6);

            lecture.AddStudents(listStudent);
            lecture.DisplayListOfStudents();

            Console.ReadKey();










        }
    }
}

