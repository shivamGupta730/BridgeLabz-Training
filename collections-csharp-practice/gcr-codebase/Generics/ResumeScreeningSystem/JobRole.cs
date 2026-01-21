using System;

namespace ResumeScreeningSystem
{
    public abstract class JobRole
    {
        private string candidateName;

        public string CandidateName
        {
            get { return candidateName; }
            set { candidateName = value; }
        }

        public abstract void Screen();
    }

    public class SoftwareEngineer : JobRole
    {
        public override void Screen()
        {
            Console.WriteLine($"Software Engineer resume screened for {CandidateName}");
        }
    }

    public class DataScientist : JobRole
    {
        public override void Screen()
        {
            Console.WriteLine($"Data Scientist resume screened for {CandidateName}");
        }
    }
}
