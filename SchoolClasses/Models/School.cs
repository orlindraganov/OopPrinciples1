namespace SchoolClasses.Models
{
    using System.Collections.Generic;

    using Interfaces;
    using Validator;

    public class School : INameable
    {
        #region Fields, Props, Ctors
        private string name;
        private List<SchoolClass> classes;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateNullOrWhiteSpace(value);
                this.name = value;
            }
        }

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }

        public School(string name)
        {
            this.name = name;
        }

        public School(string name, List<SchoolClass> classes)
        {
            this.Name = name;
            this.Classes = classes;
        }
        #endregion

        #region Methods
        public void AddClass(SchoolClass schoolClass)
        {
            Classes.Add(schoolClass);
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            Classes.Remove(schoolClass);
        }
        #endregion
    }
}
