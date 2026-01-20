using System.Collections.Generic;

namespace ResumeScreeningSystem
{
    public class ResumeUtility<T> : IResumeService<T>
        where T : JobRole
    {
        private List<T> resumes = new List<T>();

        public void AddResume(T resume)
        {
            resumes.Add(resume);
        }

        public void ProcessAll()
        {
            foreach (T r in resumes)
            {
                r.Screen();
            }
        }
    }
}
