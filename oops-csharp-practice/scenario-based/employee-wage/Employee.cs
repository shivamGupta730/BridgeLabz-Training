namespace employee_wage
{
    internal class Employee
    {
        private int wagePerHour;

        public Employee(int wagePerHour)
        {
            this.wagePerHour = wagePerHour;
        }

        public int WagePerHour
        {
            get { return wagePerHour; }
        }
    }
}
