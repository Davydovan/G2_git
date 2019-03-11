using System;

namespace Animals
{
    public class Bird : BaseAnimal
    {
        public string canFlyBird;
        public int tailLeghtBird;

        public Bird(string canFlyBird, int tailLeghtBird, int legthAnimal, string nameAnimal, string colorAnimal) : base(legthAnimal, nameAnimal, colorAnimal)
        {
            this.canFlyBird = canFlyBird;
            this.tailLeghtBird = tailLeghtBird;           
        }

        public void BirdCanFly()
        {
            Console.WriteLine($"Bird {canFlyBird}");
        }

        public override void MakeSound()
        {
            Console.WriteLine(soundAnimal);
        }
    }
}
