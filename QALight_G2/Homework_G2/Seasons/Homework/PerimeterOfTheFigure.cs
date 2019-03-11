using System;

namespace Homework
{
    public class PerimeterOfTheFigure
    {
        public int perimetr = 0;

        public void СalculateThePerimeter(int[] sideOfTheFigure)
        {

            for (int i = 0; i < sideOfTheFigure.Length; i++)
            {
                if (sideOfTheFigure.Length == 3 || sideOfTheFigure.Length == 4)
                {
                    if (sideOfTheFigure[i] >= 0)
                    {
                        perimetr = perimetr + sideOfTheFigure[i];
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("There is a negative value in the array");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You entered more than 4 sides");
                    break;
                }

            }
            Console.WriteLine(perimetr);
        }
    }
}

        
