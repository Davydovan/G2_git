using System;

namespace Animals
{
    public class Dog : BaseAnimal
    {
        public Dog(int legthAnimal, string nameAnimal, string colorAnimal) : base(legthAnimal, nameAnimal, colorAnimal)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(soundAnimal);
        }
    }
}
