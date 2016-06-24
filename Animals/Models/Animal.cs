namespace Animals.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    
    public abstract class Animal : ISound
    {
        #region Fields, Props, Ctors
        private string name;
        private int age;
        private Sex sex;

        public string Name
        {
            get
            {
                return this.name;
                    }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public Animal()
        {

        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(int age)
        {
            this.Age = age;
        }

        public Animal(Sex sex)
        {
            this.Sex = sex;
        }

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        #endregion

        #region Methods
        public abstract void MakeSound();

        public static double CalculateAverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(a => a.Age);
        }
        #endregion
    }
}
