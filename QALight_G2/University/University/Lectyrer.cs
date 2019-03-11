using System;
using System.Collections.Generic;

namespace University
{
    class Lectyrer : BaseClass
    {
        private List<Student> listGroupOfStudents;
        private List<Student> validListStudents = new List<Student>();

        public Lectyrer(string firstName, string lastName, string specialization) : base(firstName, lastName, specialization)
        {
            listGroupOfStudents = new List<Student>();
        }

        public void AddStudents(List<Student> listStudents)
        {
            if (listStudents.Count < 5)
            {
                Console.WriteLine("The list must have at least five students.");
                return;
            }


            foreach (var item in listStudents)
            {
                if (item.specialization == specialization)
                {
                    listGroupOfStudents.Add(item);

                }
                else
                {
                    Console.WriteLine($"{item.firstName}'s specialization does not coincide with the specialization of the professor.");
                }
            }

            //foreach (var item in listStudents)
            //{
            //    if (item.specialization == specialization)
            //    {
            //        validListStudents.Add(item);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{item.firstName}'s specialization does not coincide with the specialization of the professor.");
            //        continue;
            //    }

            //}

            //if (validListStudents.Count >= 5)
            //{
            //    listGroupOfStudents.AddRange(validListStudents);
            //}
            //else
            //{
            //    Console.WriteLine($"Group can't created. The lecturer has {validListStudents.Count} students. The group must be at least 5 students. ");
            //    return;
            //}



        }

        public void DisplayListOfStudents()
        {

            foreach (var item in listGroupOfStudents)
            {
                Console.WriteLine($"{item.firstName}  {item.lastName}, Specialization {item.specialization}, Course {item.course}");
            }
        }
    }
}
