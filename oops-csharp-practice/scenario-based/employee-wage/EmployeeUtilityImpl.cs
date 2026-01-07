using System;

namespace employee_wage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private readonly Random random = new Random();

        private const int WAGE_PER_HOUR = 20;
        private const int FULL_TIME_HOURS = 8;
        private const int PART_TIME_HOURS = 4;
        private const int WORKING_DAYS = 20;

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

        // UC4
        public int GetWorkingHours(int empType)
        {
            switch (empType)
            {
                case 1: return FULL_TIME_HOURS;
                case 2: return PART_TIME_HOURS;
                default: return 0;
            }
        }

        // UC5: Calculate monthly wage for 20 days
        public int CalculateMonthlyWage()
        {
            int totalWage = 0;

            for (int day = 1; day <= WORKING_DAYS; day++)
            {
                int empType = random.Next(0, 3);   // 0,1,2
                int hours = GetWorkingHours(empType);
                int dailyWage = hours * WAGE_PER_HOUR;

                totalWage += dailyWage;

                Console.WriteLine(
                    "Day " + day +
                    " | Hours: " + hours +
                    " | Wage: " + dailyWage
                );
            }

            return totalWage;
        }
    }
}
