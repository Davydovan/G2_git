using System;


namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string firstSurname = "";
            int firstAge = 0;

            firstName = Convert.ToString(Console.ReadLine());
            firstSurname = Convert.ToString(Console.ReadLine());
            firstAge = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(firstName,firstSurname,firstAge);
            Console.WriteLine("I am" + " " + firstAge + "," + " " + "my name is " + " " + firstName + " " + firstSurname);

            Console.ReadKey();
        }
    }
}
