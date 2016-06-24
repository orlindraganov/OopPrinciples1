namespace Animals.Models
{
    using System;

    using Interfaces;

    class Frog : Animal
    {
        public Frog(string name, int age, Sex sex) : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Kikiriki, kikiriki, kikiriki");
        }
    }
}
