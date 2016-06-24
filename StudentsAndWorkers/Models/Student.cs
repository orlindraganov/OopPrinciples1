namespace StudentsAndWorkers.Models
{
    using Common;

    public class Student : Human
    {
        #region Fields, Props, Ctors
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                Validator.ValidateGrade(value);
                this.grade = value;
            }
        }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        #endregion

        public override string ToString()
        {
            return string.Format($"Name: {this.FullName}, Grade: {this.Grade}");
        }
    }
}
