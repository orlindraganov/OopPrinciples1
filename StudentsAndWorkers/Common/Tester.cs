namespace StudentsAndWorkers.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public static class Tester
    {
        private static Random rand = new Random();
        private static List<string> firstNames = new List<string>() { "Pesho", "Gosho", "Vaso", "Vute", "Nane", "Gele", "Haralampiy", "Koko", "Ivo", "Value", "Kiril", "Metodiy", "Krum", "Varadin", "Icata", "Heinrich", "Richard", "Evgenyi", "Kamen", "Mitko", "John", "Adolf", "Mahmut", "Alcho", "Svetlio", "Javor", "Angel", "Peter" };
        private static List<string> lastNames = new List<string>() { "Goshov", "Peshov", "Vasov", "Vutev", "Nanev", "Gelev", "Haralampiyev", "Taskov", "Ivov", "Valuev", "Kirilov", "Metodiyev", "Krumov", "Varadinov", "Stoichkov", "Himler", "Wagner", "Stavrev", "Stanchev", "Mitkov", "Atanasov", "Unbekannte Familiename", "Mahmutlar", "Aliev", "Vitkov", "Javorov", "Angelov", "Petrov" };

        public static List<Student> PopulateStudentList(int count = 10)
        {
            var people = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                people.Add(new Student(firstNames[rand.Next(0, firstNames.Count - 1)], lastNames[rand.Next(0, lastNames.Count - 1)], rand.Next(2, 6)));
            }
            return people;
        }

        public static List<Student> SortByGrade(List<Student> students)
        {
            return (from st in students
                    orderby st.Grade ascending
                    select st).ToList<Student>();
        }

        public static List<Worker> PopulateWorkerList(int count = 10)
        {
            var people = new List<Worker>();
            for (int i = 0; i < count; i++)
            {
                var weeklySalary = decimal.Round((decimal)rand.Next(10, 1000) / rand.Next(1, 100), 2);
                var workHoursPerDay = Math.Round((double)rand.Next(24, 48) / rand.Next(2, 48), 2);
                people.Add(new Worker(
                    firstNames[rand.Next(0, firstNames.Count - 1)], 
                    lastNames[rand.Next(0, lastNames.Count - 1)], 
                    weeklySalary,
                    workHoursPerDay));
            }
            return people;
        }

        public static List<Worker> SortByMoneyPerHour(List<Worker> workers)
        {
            return (from wrk in workers
                    orderby wrk.MoneyPerHour() descending
                    select wrk).ToList();
        }
    }
}
