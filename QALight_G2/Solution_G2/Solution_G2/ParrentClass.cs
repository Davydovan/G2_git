using System;

namespace Solution_G2
{
    public class ParrentClass
    {
        public int myInt = 2345678;
        public byte myByte = 123;
        public bool myBool = true;
        public char myChar = 'A';
        public string myString = "Test string";

        public double myDouble = 4.56;
        public decimal myDecimal = 345m;
        public long myLong = 245787L;
        public uint unsignedInt;

        public virtual void TestMethod()
        {
            Console.WriteLine("Parrent class");
        }

        public int GetTwoIntegerSum(int firsNumber, int secondNumber)

        {
            return firsNumber + secondNumber;
        }

        //public int GetTwoIntegerSum(int firsNumber, string secondNumber)

        //{
        //    return 0;
        //}

        //public int GetTwoIntegerSum(int firsNumber)

        //{
        //    return 0;
        //}


        //public int GetTwoIntegerSum(string firsNumber, int secondNumber)

        //{
        //    return 0;
        //}

        public void PrintTwoIntegerSum(int firsNumber, int secondNumber)

        {
            Console.WriteLine(GetTwoIntegerSum(firsNumber,secondNumber));
        }


    }
}
