namespace SchoolClasses.Models
{
    using System.Collections.Generic;

    using Interfaces;


    public class SchoolClass : School, ICommentable
    {
        #region Fields, Props, Ctors
        private string name;
        private List<Student> students;
        private List<Teacher> teachers;
        private string comment;

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

        public SchoolClass(string name, List<Student> students, List<Teacher> teachers) : base(name)
        {
            this.Students = students;
            this.Teachers = teachers;
        }
        #endregion

        #region Methods
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            Teachers.Remove(teacher);
        }
        #endregion
    }
}
