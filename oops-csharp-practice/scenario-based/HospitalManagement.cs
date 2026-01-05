using System;

namespace OOPS_HospitalSystem
{
    // Interface for payment related logic
    interface IPayable
    {
        double CalculateBill();
    }

    // Base class Patient
    class Patient
    {
        // Encapsulation using properties
        public int PatientId { get; set; }
        public string Name { get; set; }

        // Virtual method for polymorphism
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Patient ID: " + PatientId);
            Console.WriteLine("Patient Name: " + Name);
        }
    }

    // InPatient class inherits Patient and implements IPayable
    class InPatient : Patient, IPayable
    {
        public int DaysAdmitted { get; set; }
        public double DailyCharge { get; set; }

        // Method implementation from interface
        public double CalculateBill()
        {
            return DaysAdmitted * DailyCharge;
        }

        // Method overriding
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Patient Type: InPatient");
            Console.WriteLine("Total Bill: " + CalculateBill());
        }
    }

    // OutPatient class inherits Patient and implements IPayable
    class OutPatient : Patient, IPayable
    {
        public double ConsultationFee { get; set; }

        public double CalculateBill()
        {
            return ConsultationFee;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Patient Type: OutPatient");
            Console.WriteLine("Total Bill: " + CalculateBill());
        }
    }

    class Program
    {
        static void Main()
        {
            // InPatient object
            InPatient ip = new InPatient();
            ip.PatientId = 101;
            ip.Name = "Rahul";
            ip.DaysAdmitted = 5;
            ip.DailyCharge = 2000;

            // OutPatient object
            OutPatient op = new OutPatient();
            op.PatientId = 102;
            op.Name = "Anita";
            op.ConsultationFee = 500;

            // Polymorphism
            Patient p1 = ip;
            Patient p2 = op;

            p1.DisplayInfo();
            Console.WriteLine();
            p2.DisplayInfo();
        }
    }
}
