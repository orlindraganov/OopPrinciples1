namespace SchoolClasses.Models
{
    public class Student : Person
    {
        private string name;
        private string classNumber;
     
        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

        public Student(string name, string classNumber) : base (name)
        {
            this.ClassNumber = classNumber;
        }
    }
}
