namespace SchoolClasses.Models
{
    using System.Collections.Generic;


    public class School
    {
        private List<SchoolClass> classes;

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

        public School(List<SchoolClass> classes)
        {
            this.Classes = classes;
        }   
    }
}
