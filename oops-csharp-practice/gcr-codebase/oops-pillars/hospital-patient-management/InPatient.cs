class InPatient : Patient, IMedicalRecord
{
    public override double CalculateBill()
    {
        return 5000;
    }

    public void AddRecord()
    {
        Console.WriteLine("Record Added");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Viewing Records");
    }
}
