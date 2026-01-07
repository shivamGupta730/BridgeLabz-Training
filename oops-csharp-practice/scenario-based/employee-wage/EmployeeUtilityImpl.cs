using System;

namespace employee_wage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private readonly Random random = new Random();

        private const int WAGE_PER_HOUR = 20;
        private const int FULL_TIME_HOURS = 8;
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

            return WAGE_PER_HOUR * FULL_TIME_HOURS;
        }

        // UC3
        public int CalculatePartTimeWage()
        {
            if (!CheckAttendance())
                return 0;

            return WAGE_PER_HOUR * PART_TIME_HOURS;
        }

        // UC4: employee type using switch-case
        public int GetWorkingHours(int empType)
        {
            switch (empType)
            {
                case 1: // Full time
                    return FULL_TIME_HOURS;

                case 2: // Part time
                    return PART_TIME_HOURS;

                default: // Absent
                    return 0;
            }
        }
    }
}
