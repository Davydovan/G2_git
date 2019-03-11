using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass(5, "test");

            ChildBaseClass child = new ChildBaseClass(7, "qwerty", 'g');

            int staticInt = BaseClass.staticInt;

            BaseClass baseClass1 = new BaseClass(5, "Test");
            BaseClass baseClass2 = new BaseClass(5, "Test1");

            Console.WriteLine(baseClass1.instanceInt);
            Console.WriteLine(baseClass2.instanceInt);

            // baseClass1.Test();
            //baseClass2.Test();


            //Error
            //StaticClass staticClass = new StaticClass();

            Console.ReadKey();

        }
    }
}
