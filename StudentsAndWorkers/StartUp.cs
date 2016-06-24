namespace StudentsAndWorkers
{
    using System;

    using Common;

    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Unsorted students");
            var students = Tester.PopulateStudentList();
            Util.PrintCollection(students);
            Console.WriteLine();
            Console.WriteLine("Sorted students");
            students = Tester.SortByGrade(students);
            Util.PrintCollection(students);
            Console.WriteLine();

            Console.WriteLine("Unsorted workers");
            var workers = Tester.PopulateWorkerList();
            Util.PrintCollection(workers);
            Console.WriteLine();
            Console.WriteLine("Sorted workers");
            workers = Tester.SortByMoneyPerHour(workers);
            Util.PrintCollection(workers);
            Console.WriteLine();
        }
    }
}
