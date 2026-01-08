using System;

namespace oops.Linkedlist
{
    internal class StudentRecord
    {
        class Node
        {
            public int Roll;
            public string Name;
            public int Age;
            public string Grade;
            public Node Next;

            public Node(int r, string n, int a, string g)
            {
                Roll = r;
                Name = n;
                Age = a;
                Grade = g;
                Next = null;
            }
        }

        Node head = null;

        void Add()
        {
            Console.Write("Roll: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("Age: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Grade: ");
            string g = Console.ReadLine();

            Node node = new Node(r, n, a, g);

            if (head == null)
            {
                head = node;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = node;
        }

        void Delete()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            Console.Write("Roll: ");
            int r = int.Parse(Console.ReadLine());

            if (head.Roll == r)
            {
                head = head.Next;
                Console.WriteLine("Deleted");
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Roll != r)
                temp = temp.Next;

            if (temp.Next == null)
                Console.WriteLine("Record Not Found");
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Deleted");
            }
        }

        void Search()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            Console.Write("Roll: ");
            int r = int.Parse(Console.ReadLine());

            Node temp = head;
            while (temp != null)
            {
                if (temp.Roll == r)
                {
                    Console.WriteLine(temp.Roll + " " + temp.Name + " " + temp.Grade);
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Record Not Found");
        }

        void UpdateGrade()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            Console.Write("Roll: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("New Grade: ");
            string g = Console.ReadLine();

            Node temp = head;
            while (temp != null)
            {
                if (temp.Roll == r)
                {
                    temp.Grade = g;
                    Console.WriteLine("Updated");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Record Not Found");
        }

        void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Roll + " " + temp.Name + " " + temp.Age + " " + temp.Grade);
                temp = temp.Next;
            }
        }

        static void Main()
        {
            StudentRecord s = new StudentRecord();
            int ch;

            do
            {
                Console.WriteLine("\n1 Add");
                Console.WriteLine("2 Delete");
                Console.WriteLine("3 Search");
                Console.WriteLine("4 Update Grade");
                Console.WriteLine("5 Display");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) s.Add();
                else if (ch == 2) s.Delete();
                else if (ch == 3) s.Search();
                else if (ch == 4) s.UpdateGrade();
                else if (ch == 5) s.Display();

            } while (ch != 0);
        }
    }
}
