using System;

namespace ResumeScreeningSystem
{
    public class ResumeMenu
    {
        public void ShowMenu()
        {
            ResumeUtility<JobRole> utility =
                new ResumeUtility<JobRole>();

            int choice;
            do
            {
                Console.WriteLine("\n1. Add Software Engineer Resume");
                Console.WriteLine("2. Add Data Scientist Resume");
                Console.WriteLine("3. Process All Resumes");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SoftwareEngineer se = new SoftwareEngineer();
                        Console.Write("Enter Candidate Name: ");
                        se.CandidateName = Console.ReadLine();
                        utility.AddResume(se);
                        break;

                    case 2:
                        DataScientist ds = new DataScientist();
                        Console.Write("Enter Candidate Name: ");
                        ds.CandidateName = Console.ReadLine();
                        utility.AddResume(ds);
                        break;

                    case 3:
                        Console.WriteLine("\n--- Screening Resumes ---");
                        utility.ProcessAll();
                        break;
                }

            } while (choice != 0);
        }
    }
}
