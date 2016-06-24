using System;
using System.Collections.Generic;

using StudentsAndWorkers.Models;

namespace StudentsAndWorkers.Common
{
    public static class Util
    {
        public static void PrintCollection(IEnumerable<Object> collection)
        {
            foreach (var human in collection)
            {
                Console.WriteLine(human);
            }
        }
    }
}
