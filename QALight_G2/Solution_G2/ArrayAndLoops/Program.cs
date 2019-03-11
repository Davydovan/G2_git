
using System;

namespace ArrayAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            // object[] array = new object[5]; - так ніколи не робити 

            //string[] array = new string[5];

            //array[0] = 45;
            //array[1] = "string";
            //array[2] = 'c';

            int[] intArray = { 23, 54, 2, 9 };
            int[] intArray1 = new int[4];
            #endregion

            #region While

            //int counter = 1; 

            //while (counter < 6)
            //{
            //    Console.WriteLine(counter);
            //    //counter = counter + 1; or ->>
            //    //counter += counter;  or ->>  
            //    counter++; 
            //}

            //Console.ReadKey();
            #endregion

            #region Do-While
            //int counter1 = 1;

            //do
            //{
            //    Console.WriteLine(counter1);
            //    counter1++;

            //} while (counter1 < 6);


            #endregion

            #region For

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i < 6; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < 6; i++)
            //{
            //    if (i == 3)
            //    {
            //       continue;
            //    }
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Foreach

            int[] array2 = { 3, 4, 5, 8 };

            foreach (var number in array2)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < array2.Length ; i++)
            {
                Console.WriteLine(array2[i]);
            }

            #endregion

            Console.ReadKey();


        }
    }
}
