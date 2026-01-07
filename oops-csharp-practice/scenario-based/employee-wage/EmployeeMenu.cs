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
            Console.WriteLine("3. UC3 - Calculate Part Time Wage");
            Console.WriteLine("4. UC4 - Employee Type Working Hours");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        utility.CheckAttendance()
                            ? "Employee is Present"
                            : "Employee is Absent"
                    );
                    break;

                case 2:
                    Console.WriteLine("Daily Wage = " + utility.CalculateDailyWage());
                    break;

                case 3:
                    Console.WriteLine("Part Time Wage = " + utility.CalculatePartTimeWage());
                    break;

                case 4:
                    Console.Write("Enter Employee Type (0-Absent, 1-FullTime, 2-PartTime): ");
                    int type = int.Parse(Console.ReadLine());

                    int hours = utility.GetWorkingHours(type);
                    int wage = hours * 20;

                    Console.WriteLine("Working Hours = " + hours);
                    Console.WriteLine("Wage = " + wage);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
