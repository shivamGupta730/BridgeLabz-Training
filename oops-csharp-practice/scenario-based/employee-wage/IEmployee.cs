namespace employee_wage
{
    interface IEmployee
    {
        bool CheckAttendance();                 // UC1
        int CalculateDailyWage(int wagePerHour); // UC2
    }
}
