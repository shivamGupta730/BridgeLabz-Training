namespace employee_wage
{
    interface IEmployee
    {
        bool CheckAttendance();        // UC1
        int CalculateDailyWage();      // UC2
        int CalculatePartTimeWage();   // UC3
    }
}
