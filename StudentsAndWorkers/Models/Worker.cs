namespace StudentsAndWorkers.Models
{
    using Common;

    public class Worker : Human
    {
        #region Fields, Props, Ctors
        private decimal weeklySalary;
        private double workHoursPerDay;

        public decimal WeeklySalary
        {
            get
            {
                return this.weeklySalary;
            }
            set
            {
                Validator.ValidateSalary(value);
                this.weeklySalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weeklySalary = 150M, double workHoursPerDay = 8D) : base(firstName, lastName)
        {
            this.WeeklySalary = weeklySalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        #endregion

        #region Methods
        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (this.WeeklySalary / GlobalConsts.workDaysPerWeek) / (decimal)workHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format($"Name: {this.FullName}, Weekly Salary: {this.WeeklySalary}, Working Hours Per Day {this.WorkHoursPerDay}");
        }
        #endregion
    }
}
