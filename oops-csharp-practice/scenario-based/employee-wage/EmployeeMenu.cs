using System;

namespace employee_wage
{
    sealed class EmployeeMenu
    {
        public void Start()
        {
            EmployeeUtilityImpl utility = new EmployeeUtilityImpl();

            Console.WriteLine(" Employee Attendance Check");

            bool isPresent = utility.CheckAttendance();

            if (isPresent)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
