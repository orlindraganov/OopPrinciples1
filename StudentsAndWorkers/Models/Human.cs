namespace StudentsAndWorkers.Models
{
    public abstract class Human
    {
        #region Fields, Props, Ctors
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format($"{this.firstName} {this.lastName}");
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        #endregion
    }
}
