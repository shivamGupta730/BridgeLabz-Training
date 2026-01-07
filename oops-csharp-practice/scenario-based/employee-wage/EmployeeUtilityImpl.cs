using System;

namespace employee_wage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private readonly Random random = new Random();
        private const int FULL_DAY_HOURS = 8;

        // UC1
        public bool CheckAttendance()
        {
            return random.Next(0, 2) == 1;
        }

        // UC2: calculate daily wage
        public int CalculateDailyWage(int wagePerHour)
        {
            bool isPresent = CheckAttendance();

            if (!isPresent)
                return 0;

            return wagePerHour * FULL_DAY_HOURS;
        }
    }
}
