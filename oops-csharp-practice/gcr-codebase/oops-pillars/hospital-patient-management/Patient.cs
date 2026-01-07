abstract class Patient
{
    protected int age;

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Age : " + age);
    }
}
