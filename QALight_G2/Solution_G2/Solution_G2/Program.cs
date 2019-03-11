using System;

namespace Solution_G2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Danger! Explicit types' converting
            //int a = 500;
            //byte b = 7;
            //b = (byte) a;
            //Console.WriteLine(b);

            ParrentClass parentClass = new ParrentClass();
            //parentClass.myBool = true;
            //Console.WriteLine(parentClass.myBool);

            //ChildClass childClass = new ChildClass();
            //Console.WriteLine(childClass.childInt);

            // Impossible, follow us to exception
            //childClass = (ChildClass)parentClass;
            //Console.WriteLine(childClass.childInt);

            //parentClass.TestMethod();
            //childClass.TestMethod();
            int a = 5;
            int b = 10;
         
            parentClass.PrintTwoIntegerSum(a,b);
            var resalt = parentClass.GetTwoIntegerSum(a,b);



            Console.ReadKey();
        }
    }
}
