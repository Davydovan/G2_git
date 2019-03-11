using System;

namespace UnitTest
{
    class Calculator
    {
        public static int DivideTwoIntegers(int firstNumber, int secondNumber)
        {
            CheckNumberValid(firstNumber);
            CheckNumberValid(secondNumber);
            return firstNumber / secondNumber;
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

