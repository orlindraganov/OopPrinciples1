namespace Animals.Models
{
    using Interfaces;

    class Tomcat : Cat
    {
        private string name;
        private int age;
        private Sex sex;


        public Tomcat(string name, int age, Sex sex) : base(name, age, Sex.male)
        {
        }
    }
}
