namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common;
    using Models;

    class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Unsorted students");
            var students = Tester.PopulateStudentList();
            Util.PrintCollection(students);
            Console.WriteLine();
            
            //Demonstrating OrderBy + Lambda
            Console.WriteLine("Sorted students");
            students = students.OrderBy(x => x.Grade).ToList();
            Util.PrintCollection(students);
            Console.WriteLine();

            Console.WriteLine("Unsorted workers");
            var workers = Tester.PopulateWorkerList();
            Util.PrintCollection(workers);
            Console.WriteLine();

            //Demonstrating Linq
            Console.WriteLine("Sorted workers");
            workers = (from wrk in workers
                      orderby wrk.MoneyPerHour() descending
                      select wrk).ToList();
            Util.PrintCollection(workers);
            Console.WriteLine();

            Console.WriteLine("Unsorted people");
            var people = new List<Human>(students);
            people.AddRange(workers);
            Util.PrintCollection(people);

            //Demonstrating OrderBy.ThenBy
            Console.WriteLine("Sorted people");
            people = people.OrderBy(p => p.FirstName).
                            ThenBy(p => p.LastName).
                            ToList();
            Util.PrintCollection(people);

        }
    }
}
