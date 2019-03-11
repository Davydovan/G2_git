

using System;

namespace UnitTests
{
    class Calculator
    {
        public static int GetSomeTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public static int DivideTwoIntegers(int a, int b)
        {
            CheckNumberValid(a);
            CheckNumberValid(b);
            return a / b;
        }

        public static void CheckNumberValid(int a)
        {
            if (a < -1000 || a > 1000)
            {
                throw new ArgumentException("Value should be" + 
                    "from -1000 to 1000.");
            }
        }
    }

}
