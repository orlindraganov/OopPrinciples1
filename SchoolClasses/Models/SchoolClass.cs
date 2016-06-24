namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;


    public class SchoolClass : ICommentable
    {
        private string name;
        private List<Student> students;
        private List<Teacher> teachers;
        private string comment;

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

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
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


        public SchoolClass(string name, List<Student> students, List<Teacher> teachers)
        {
            this.Name = name;
            this.Students = students;
            this.Teachers = teachers;
        }
    }
}
