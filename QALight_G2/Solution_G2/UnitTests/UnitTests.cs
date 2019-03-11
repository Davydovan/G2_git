using NUnit.Framework;
using System;

namespace UnitTests
{
   
    public class UnitTests
    {
        [OneTimeSetUp]
        public void BeforeAllTest()
        {
            Console.WriteLine("BeforeAllTest");
        }

        [OneTimeTearDown]
        public void AfterAllTest()
        {
            Console.WriteLine("AfterAllTest");
        }


        [SetUp]
        public void BeforeEveryTest()
        {
            Console.WriteLine("BeforeEveryTest");
        }

        [TearDown]
        public void AfterEveryTest()
        {
            Console.WriteLine("AfterEveryTest");
        }

        [Category("CalculatorTest")]
        [Category("CalculatorTest1")]
        [Test]
        public void GetSomeTwoNumbers_ValidInteger_Success()
        {
            // Arrange
            int firstNumber = 2;
            int secondNumber = 5;
            int expectedResult = 7;

            //Act
            int actualResalt = Calculator
                .GetSomeTwoNumbers(firstNumber, secondNumber);

            //Assert
            Assert.True(actualResalt == expectedResult,
                $"Expected sum of {firstNumber} and {secondNumber} is {expectedResult}." +
                $"Actual resalt is {actualResalt}.");
        }


            [Test]
        public void JustTest()
        {
            Console.WriteLine(Calculator.DivideTwoIntegers(3,5));
            Console.WriteLine("Another test");
        }

        [Test]
        public void DivideTwoIntegers_DivedeByZero_Exception()
        {
            //Arrange
            int a = 5;
            int b = 0;

            //Assert
            Assert.Throws<DivideByZeroException>(() 
                => Calculator.DivideTwoIntegers(a, b));
            
        }

        [Test]
        public void CheckNumberValid_InvalidArgument_Exception()
        {
            //Arrange
            int a = 5000;
            int b = 5;

            //Assert
            Assert.Throws<ArgumentException>(()
                => Calculator.DivideTwoIntegers(a, b));

        }
    }
}

