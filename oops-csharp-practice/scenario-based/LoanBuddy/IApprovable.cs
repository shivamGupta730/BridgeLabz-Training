namespace LoanBuddy
{
    interface IApprovable
    {
        bool ApproveLoan(Applicant a);
        double CalculateEMI();
    }
}
