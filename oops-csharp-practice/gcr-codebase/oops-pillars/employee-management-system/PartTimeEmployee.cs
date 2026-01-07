class PartTimeEmployee : Employee, IDepartment
{
    private int hours;
    private string department;

    public PartTimeEmployee(int hrs, double rate)
    {
        hours = hrs;
        baseSalary = rate;
    }

    public override double CalculateSalary()
    {
        return hours * baseSalary;
    }

    public void AssignDepartment(string dept)
    {
        department = dept;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}
