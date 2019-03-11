using System;

namespace Seasons
{
    class NumberMonth
    {
        public int monthNumber;

        public void TimeOfYearDependOnTheNumberMonth()
        {
            Console.WriteLine("Enter month number");
            monthNumber = Convert.ToInt32(Console.ReadLine());

            #region Switch

            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write($"It is Winter. Number of month is {monthNumber}");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.Write($"It is Spring. Number of month is {monthNumber}");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.Write($"It is Summer. Number of month is {monthNumber}");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.Write($"It is Autumn.Number of month is {monthNumber}");
                    break;

                default:
                    Console.Write("Please  enter value from 1 to 12");
                    break;
            }
            #endregion

            #region IfElse
            if (monthNumber >=3 && monthNumber <=5)
            {
                Console.Write($"It is Spring. Number of month is {monthNumber}");
            }

            else if (monthNumber >= 6 && monthNumber <= 8)
            {
                Console.Write($"It is Summer. Number of month is {monthNumber}");
            }

            else if (monthNumber >= 9 && monthNumber <= 11)
            {
                Console.Write($"It is Atumn. Number of month is {monthNumber}");
            }

            else if (monthNumber == 1 || monthNumber == 2 || monthNumber == 12)
            {
                Console.Write($"It is Winter. Number of month is {monthNumber}");
            }

            else
            {
                Console.Write("Please  enter value from 1 to 12");
            }
            #endregion
        }
    }
}
