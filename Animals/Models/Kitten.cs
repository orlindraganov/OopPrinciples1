namespace Animals.Models
{
    using Interfaces;

    class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, Sex sex) : base(name, age, Sex.female) { }
    }
}
