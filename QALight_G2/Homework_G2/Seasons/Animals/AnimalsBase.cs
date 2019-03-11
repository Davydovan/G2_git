using System;

namespace Animals
{
    public class BaseAnimal
    {
        public int legthAnimal;
        public string nameAnimal;
        public string colorAnimal;
        protected string soundAnimal;

        public BaseAnimal(int legthAnimal, string nameAnimal, string colorAnimal)
        {
            this.legthAnimal = legthAnimal;
            this.nameAnimal = nameAnimal;
            this.colorAnimal = colorAnimal;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"The sound is {soundAnimal}");
        }
    }
}
