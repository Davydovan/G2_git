using System;

namespace Homework
{
    class Program
    {
        //#region FourthTask the sum of all even numbers in the array int [] array
        //public class SumNumberArray
        //{
        //    int[] array = { 2, 4, 25, 50 };
        //    int sum = 0;

        //    public void SumOfAllEvenNumbersInTheArray()
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            if (array[i] % 2 == 0)
        //            {
        //                sum = sum + array[i];

        //            }
        //        }
        //        Console.WriteLine(sum);
        //    }
        //}
        //#endregion


        static void Main(string[] args)

        {
            //Console.WriteLine("1. Написать метод, который подсчитывает периметр фигуры в зависимости от кол-ва сторон.Метод должен считать периметр для треугольника, прямоугольника и квадрата.");
            //PerimeterOfTheFigure perimeterOfTheFigure = new PerimeterOfTheFigure();
            //perimeterOfTheFigure.СalculateThePerimeter(new int[5] { 2, 3, 6, 11, 2 });

            #region SecondTask_For

            //Console.WriteLine("2. Написать код, выводящий в консоль числа от 1 до 100 (включительно) с условием: если число делится на 3, то вместо него писать Fizz, если делится на 5, то Buzz. А если делится и на 3, и на 5 – FizzBuzz.");

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }

            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }

            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region SecondTask_While
            //Console.WriteLine("2. Написать код, выводящий в консоль числа от 1 до 100 (включительно) с условием: если число делится на 3, то вместо него писать Fizz, если делится на 5, то Buzz. А если делится и на 3, и на 5 – FizzBuzz.");


            //int counter = 0;

            //while (counter < 101)
            //{
            //    counter++;
            //    if (counter % 3 == 0 && counter % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }

            //    else if (counter % 3 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //    else if (counter % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }

            //    else
            //    {
            //        Console.WriteLine(counter);
            //    }
            //}

            #endregion

            #region SecondTask_Do-While
            //Console.WriteLine("2. Написать код, выводящий в консоль числа от 1 до 100 (включительно) с условием: если число делится на 3, то вместо него писать Fizz, если делится на 5, то Buzz. А если делится и на 3, и на 5 – FizzBuzz.");

            //int counter = 1;

            //do
            //{
            //    if (counter % 3 == 0 && counter % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }

            //    else if (counter % 3 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }

            //    else if (counter % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }

            //    else
            //    {
            //        Console.WriteLine(counter);
            //    }
            //    counter++;

            //} while (counter < 101);


            #endregion

            #region ThirdTask-Array MaxElement
            //Console.WriteLine("3) Объявить массив чисел из 10 элементов и написать код для поиска максимального значения");

            //int[] array = new int[10];
            ////int[] array = new int[10] { 67, 69, 70, 8, 35, 96, 89, 306, 10, 306 };
            //int maxValue = array[0];

            //foreach (int number in array)
            //{
            //    if (maxValue < number)
            //    {
            //        maxValue = number;
            //    }
            //}
            //Console.WriteLine(maxValue);

            #endregion

            //Console.WriteLine("4. Написать метод, суммирующий все четные числа массива int[] array.");
            //SumNumberArray sumNumberArray = new SumNumberArray();
            //sumNumberArray.SumOfAllEvenNumbersInTheArray();

            #region FifthTask the minimum value of the element with an odd index
            //Console.WriteLine("5. Объявить массив из 5 чисел и найти минимальное значение элемента с нечетным индексом. ");

            //int[] array = { -2, 1, -3, -1, -15 };

            //int minValue = array[1];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }

            //    if (array[i] < minValue)
            //    {
            //        minValue = array[i];
            //    }

            //}

            //Console.WriteLine(minValue);

            #endregion

            //Console.WriteLine("6. Написать метод, принимающий как параметр строку и выводящий в консоль эту строку посимвольно,каждый символ в новой строке. ");
            //StringArray stringArray = new StringArray();
            //stringArray.CharacterStringOutput("Natasha Davydova");


            //Console.WriteLine("7. Write a method to sort the array in reverse order");
            //SortTheArrayInReverse sortTheArrayInReverse = new SortTheArrayInReverse();
            //sortTheArrayInReverse.SortTheArrayInReverseMethod(new int[5] { 1, 2, 3, 4, 5 });

            Console.ReadKey();
        }
    }
}

