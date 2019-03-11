using System;

namespace Homeworkone
{
    class Program
    {
        public static void MethodSum(int n, int m)
        {
          Console.WriteLine("Sum:" + (n + m).ToString());
        }
      

        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Enter the first number and press Entern");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number and press Entern");
            m = Convert.ToInt32(Console.ReadLine());
            MethodSum(n, m);
            Console.ReadKey();

            Person person = new Person();
            person.PersonMethod();
            Console.ReadKey();
        }
       
    }
     
 }

