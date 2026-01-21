namespace ResumeScreeningSystem
{
    public interface IResumeService<T>
    {
        void AddResume(T resume);
        void ProcessAll();
    }
}
