using System;
using System.Collections.Generic;

class RankUtility : IRankService
{
    private List<Student> students = new List<Student>();

    public void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter Roll No: ");
        s.RollNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        s.Marks = int.Parse(Console.ReadLine());

        students.Add(s);
    }

    public void GenerateRankList()
    {
        List<Student> sortedList = MergeSort(students);

        Console.WriteLine("\n--- State Wise Rank List ---");
        int rank = 1;
        foreach (var s in sortedList)
        {
            Console.WriteLine($"Rank {rank++}: {s.Name} - {s.Marks}");
        }
    }

    private List<Student> MergeSort(List<Student> list)
    {
        if (list.Count <= 1)
            return list;

        int mid = list.Count / 2;

        List<Student> left = MergeSort(list.GetRange(0, mid));
        List<Student> right = MergeSort(list.GetRange(mid, list.Count - mid));

        return Merge(left, right);
    }

    private List<Student> Merge(List<Student> left, List<Student> right)
    {
        List<Student> result = new List<Student>();
        int i = 0, j = 0;

        while (i < left.Count && j < right.Count)
        {
            if (left[i].Marks > right[j].Marks)
                result.Add(left[i++]);
            else if (left[i].Marks < right[j].Marks)
                result.Add(right[j++]);
            else
                result.Add(left[i++]); // stability
        }

        while (i < left.Count)
            result.Add(left[i++]);

        while (j < right.Count)
            result.Add(right[j++]);

        return result;
    }
}
