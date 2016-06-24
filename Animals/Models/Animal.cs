namespace Animals.Models
{
    class Animal
    {
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

        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
}
