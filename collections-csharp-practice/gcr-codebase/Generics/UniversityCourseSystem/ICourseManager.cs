namespace UniversityCourseSystem
{
    public interface ICourseManager<T>
    {
        void AddCourse(T course);
        void EvaluateAll();
    }
}
