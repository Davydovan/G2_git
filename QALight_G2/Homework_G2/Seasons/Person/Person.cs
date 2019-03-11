using System;

namespace Person
{
    class Person
    {

        public string name;
        public string surname;
        public int age;


        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;


            if (this.name.Length <= 2)
            {
                Console.WriteLine("Enter more than two characters");
                Console.WriteLine("Enter name");
                name = Convert.ToString(Console.ReadLine());
            }


            if (this.surname.Length <= 2)
            {
                Console.WriteLine("Enter more than two characters");
                Console.WriteLine("Enter surname");
                surname = Convert.ToString(Console.ReadLine());
            }


            if (this.age < 0 && age > 120)
            {
                Console.WriteLine("Enter from 1 to 120");
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
            }
            return;
             

        }

        //public void DisplayInformationAboutPerson() 
        //{
        //    Console.WriteLine("Enter name");
        //    name = Convert.ToString(Console.ReadLine());
        //    if (name.Length > 2)
        //    {

        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter more than two characters");
        //        Console.WriteLine("Enter name");
        //        name = Convert.ToString(Console.ReadLine());
        //    }



        //    Console.WriteLine("Enter surname");
        //    surname = Convert.ToString(Console.ReadLine());
        //    if (surname.Length > 2)
        //    {

        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter more than two characters");
        //        Console.WriteLine("Enter surname");
        //        surname = Convert.ToString(Console.ReadLine());
        //    }



        //    Console.WriteLine("Enter age");
        //    age = Convert.ToInt32(Console.ReadLine());
        //    if (age > 0 && age <= 120)
        //    {

        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter from 1 to 120");
        //        Console.WriteLine("Enter age");
        //        age = Convert.ToInt32(Console.ReadLine());
        //    }

        //    Console.WriteLine("I am" + " " + age + "," + " " + "my name is " + " " + name + " " + surname);



            //if (name.Length > 2 && surname.Length > 2 && age > 0 && age <= 120)
            //{
            //    Console.WriteLine("I am" + " " + age + "," + " " + "my name is " + " " + name + " " + surname);
            //}

            //else
            //{
            //    Console.WriteLine("Please enter more than two characters name or surname or age from 1 to 120 ");
            //}


        }

    }



    
