using System;

namespace Animals
{
    public class Fish : BaseAnimal
    {
        public int firstDepth = 0;
        public Fish(int legthAnimal, string nameAnimal, string colorAnimal) : base(legthAnimal, nameAnimal, colorAnimal)
        {
        }

        public int Dive (int diveDepth)
        {
            firstDepth = firstDepth + diveDepth;
            return firstDepth;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The fish can't make sound");
        }
    }

}
