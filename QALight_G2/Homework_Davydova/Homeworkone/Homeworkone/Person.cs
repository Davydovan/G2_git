using System;

namespace Homeworkone
{
    public class Person
    {
        public string Name { get;} = "Natalia";
        public string Surname { get; } = "Davydova";
        public int Age { get; } = 30;

        public void PersonMethod()
        {
            Console.WriteLine("I am" + " " + Age + "," + " " + "my name is " + " " + Name + " " + Surname);
            
        }
       
    }


}
