namespace Animals.Models
{
    using System;

    using Interfaces;

    class Dog : Animal
    {
        public Dog(string name, int age, Sex sex) : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Van! Van! Van!");
        }
    }
}
