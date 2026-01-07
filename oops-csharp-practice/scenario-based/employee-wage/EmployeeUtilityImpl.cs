using System;

namespace employee_wage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private readonly Random random = new Random();

        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOURS = 8;
        private const int PART_TIME_HOURS = 4;

        // UC1
        public bool CheckAttendance()
        {
            return random.Next(0, 2) == 1;
        }

        // UC2
        public int CalculateDailyWage()
        {
            if (!CheckAttendance())
                return 0;

            return WAGE_PER_HOUR * FULL_DAY_HOURS;
        }

        // UC3 
        public int CalculatePartTimeWage()
        {
            if (!CheckAttendance())
                return 0;

            return WAGE_PER_HOUR * PART_TIME_HOURS;
        }
    }
}
