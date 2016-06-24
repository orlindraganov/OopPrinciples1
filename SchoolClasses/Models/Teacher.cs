namespace SchoolClasses.Models
{
    using Interfaces;
    using System.Collections.Generic;


    public class Teacher : Person, INameable, ICommentable
    {
        private string name;
        private List<Discipline> disciplines;
        private string comment;

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public Teacher(string name, List<Discipline> disciplines) : base (name)
        {
            this.Disciplines = disciplines;
        }
    }
}
