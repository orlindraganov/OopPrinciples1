namespace SchoolClasses.Models
{
    using Interfaces;
    using Validator;

    public class Discipline : School, INameable, ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcercises;
        private string comment;

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                Validator.ValidateNonNegative(value, "NumberOfLectures");
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            set
            {
                Validator.ValidateNonNegative(value, "NumberOfExcercises");
                this.numberOfExcercises = value;
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

        public Discipline(string name, int numberOfLectures, int numberOfExcercises) : base (name)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }
    }
}
