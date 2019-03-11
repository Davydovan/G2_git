using NUnit.Framework;
using System;


namespace UnitTest
{
    public class UnitTests
    {
       
        [Test]
        public void GetSomeTwoNumbers_ValidInteger_Success()
        {
            // Arrange
            int firstNumber = 10;
            int secondNumber = 5;
            int expectedResult = 2;

            //Act
            int actualResalt = Calculator
                .DivideTwoIntegers(firstNumber, secondNumber);

            //Assert
            Assert.True(actualResalt == expectedResult,
                $"Expected sum of {firstNumber} and {secondNumber} is {expectedResult}." +
                $"Actual resalt is {actualResalt}.");
        }


        [Test]
        public void DivideTwoIntegers_DivedeByZero_Exception()
        {
            //Arrange
            int firstNumber = 5;
            int secondNumber = 0;

            //Assert
            Assert.Throws<DivideByZeroException>(()
                => Calculator.DivideTwoIntegers(firstNumber, secondNumber));

        }

        [Test]
        public void CheckNumberValid_InvalidArgument_Exception()
        {
            //Arrange
            int firstNumber = 5;
            int secondNumber = -1001;

            //Assert
            Assert.Throws<ArgumentException>(()
                => Calculator.DivideTwoIntegers(firstNumber, secondNumber));

        }
    
    }
}

         


