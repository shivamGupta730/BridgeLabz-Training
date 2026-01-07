using System;

namespace employee_wage
{
    sealed class EmployeeMenu
    {
        public void Start()
        {
            EmployeeUtilityImpl utility = new EmployeeUtilityImpl();

            Console.WriteLine("===== EMPLOYEE WAGE MENU =====");
            Console.WriteLine("1. UC1 - Check Attendance");
            Console.WriteLine("2. UC2 - Calculate Daily Wage");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:   // UC1
                    if (utility.CheckAttendance())
                        Console.WriteLine("Employee is Present");
                    else
                        Console.WriteLine("Employee is Absent");
                    break;

                case 2:   // UC2
                    int wagePerHour = 20;
                    int dailyWage = utility.CalculateDailyWage(wagePerHour);
                    Console.WriteLine("Daily Wage = " + dailyWage);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
