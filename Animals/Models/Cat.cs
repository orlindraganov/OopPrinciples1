namespace Animals.Models
{
    using System;

    using Interfaces;

    class Cat : Animal, ISound
    {
        private string name;
        private int age;

        public Cat(string name, int age, Sex sex) : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow! Meow!");
        }
    }
}
