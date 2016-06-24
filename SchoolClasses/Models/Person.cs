namespace SchoolClasses.Models
{
    using Interfaces;
    using Validator;

    public abstract class Person : INameable, ICommentable
    {
        private string name;
        private string comment;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateNullOrWhiteSpace(value, "Person name");
                this.name = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string comment)
        {
            this.Name = name;
            this.Comment = comment;
        }
    }
}
