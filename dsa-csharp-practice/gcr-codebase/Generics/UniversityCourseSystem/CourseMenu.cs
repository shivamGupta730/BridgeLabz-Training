using System;

namespace UniversityCourseSystem
{
    public class CourseMenu
    {
        public void ShowMenu()
        {
            CourseUtility<CourseType> manager =
                new CourseUtility<CourseType>();

            int choice;
            do
            {
                Console.WriteLine("\n1. Add Exam Course");
                Console.WriteLine("2. Add Assignment Course");
                Console.WriteLine("3. Evaluate All Courses");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ExamCourse ec = new ExamCourse();
                        Console.Write("Enter Course Name: ");
                        ec.CourseName = Console.ReadLine();
                        manager.AddCourse(ec);
                        break;

                    case 2:
                        AssignmentCourse ac = new AssignmentCourse();
                        Console.Write("Enter Course Name: ");
                        ac.CourseName = Console.ReadLine();
                        manager.AddCourse(ac);
                        break;

                    case 3:
                        Console.WriteLine("\n--- Course Evaluation ---");
                        manager.EvaluateAll();
                        break;
                }

            } while (choice != 0);
        }
    }
}
