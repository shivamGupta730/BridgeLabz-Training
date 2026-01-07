using System;

namespace employee_wage
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private readonly Random random = new Random();

        // UC1: check employee attendance using random
        public bool CheckAttendance()
        {
            return random.Next(0, 2) == 1;
        }
    }
}
