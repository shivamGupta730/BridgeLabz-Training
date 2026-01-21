using System;

namespace UniversityCourseSystem
{
    public abstract class CourseType
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public abstract void Evaluate();
    }

    public class ExamCourse : CourseType
    {
        public override void Evaluate()
        {
            Console.WriteLine($"Exam based evaluation for {CourseName}");
        }
    }

    public class AssignmentCourse : CourseType
    {
        public override void Evaluate()
        {
            Console.WriteLine($"Assignment based evaluation for {CourseName}");
        }
    }
}
