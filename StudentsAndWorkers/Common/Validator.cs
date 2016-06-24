namespace StudentsAndWorkers.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Validator
    {
        public static void ValidateGrade(double grade, string paramName = "Grade")
        {
            if (GlobalConsts.minGrade > grade || grade > GlobalConsts.maxGrade)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Argument should be between {GlobalConsts.minGrade} and {GlobalConsts.maxGrade}"); 
            }
        }

        public static void ValidateSalary(decimal salary, string paramName = "Salary")
        {
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, "Argument cannot be negative");
            }
        }

        public static void ValidateWorkHoursPerDay(double workHoursPerDay, string paramName = "WorkHoursPerDay")
        {
            if (0 >= workHoursPerDay || workHoursPerDay > GlobalConsts.maxWorkHoursPerDay)
            {
                throw new ArgumentOutOfRangeException(paramName, $"Argument should be between 0 and {GlobalConsts.maxWorkHoursPerDay}");
            }
        }
    }
}
