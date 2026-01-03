using System;

class HospitalPatientProgram
{
    static string hospitalName;
    static int totalPatients = 0;

    string name;
    int age;
    string disease;
    readonly int patientId;

    HospitalPatientProgram(string name, int age, string disease, int patientId)
    {
        this.name = name;
        this.age = age;
        this.disease = disease;
        this.patientId = patientId;
        totalPatients++;
    }

    static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients: " + totalPatients);
    }

    void ShowPatient(object obj)
    {
        if (obj is HospitalPatientProgram)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Disease: " + disease);
        }
    }

    static void Main()
    {
        Console.Write("Enter Hospital Name: ");
        hospitalName = Console.ReadLine();

        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Disease: ");
        string disease = Console.ReadLine();

        Console.Write("Enter Patient ID: ");
        int id = int.Parse(Console.ReadLine());

        HospitalPatientProgram patient =
            new HospitalPatientProgram(name, age, disease, id);

        Console.WriteLine("Hospital: " + hospitalName);
        patient.ShowPatient(patient);
        GetTotalPatients();
    }
}
