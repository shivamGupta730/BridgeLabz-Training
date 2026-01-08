using System;

namespace oops.Linkedlist
{
    internal class TaskScheduler
    {
        class Node
        {
            public int Id;
            public string Name;
            public int Priority;
            public string DueDate;
            public Node Next;

            public Node(int i, string n, int p, string d)
            {
                Id = i;
                Name = n;
                Priority = p;
                DueDate = d;
                Next = null;
            }
        }

        Node head = null;
        Node current = null;

        void AddBegin()
        {
            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            Node node = new Node(i, n, p, d);

            if (head == null)
            {
                head = node;
                node.Next = head;
                current = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            node.Next = head;
            temp.Next = node;
            head = node;
        }

        void AddEnd()
        {
            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            Node node = new Node(i, n, p, d);

            if (head == null)
            {
                head = node;
                node.Next = head;
                current = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = node;
            node.Next = head;
        }

        void AddPosition()
        {
            int pos = int.Parse(Console.ReadLine());

            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            Node node = new Node(i, n, p, d);

            if (pos == 1)
            {
                AddBegin();
                return;
            }

            Node temp = head;
            for (int c = 1; c < pos - 1 && temp.Next != head; c++)
                temp = temp.Next;

            node.Next = temp.Next;
            temp.Next = node;
        }

        void Remove()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            int id = int.Parse(Console.ReadLine());

            if (head.Id == id && head.Next == head)
            {
                head = null;
                current = null;
                return;
            }

            if (head.Id == id)
            {
                Node temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                head = head.Next;
                temp.Next = head;
                current = head;
                return;
            }

            Node cur = head;
            while (cur.Next != head && cur.Next.Id != id)
                cur = cur.Next;

            if (cur.Next == head)
            {
                Console.WriteLine("Not Found");
                return;
            }

            cur.Next = cur.Next.Next;
        }

        void ViewNext()
        {
            if (current == null)
            {
                Console.WriteLine("No Task");
                return;
            }

            Console.WriteLine(current.Id + " " + current.Name);
            current = current.Next;
        }

        void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            Node temp = head;
            do
            {
                Console.WriteLine(temp.Id + " " + temp.Name + " " + temp.Priority + " " + temp.DueDate);
                temp = temp.Next;
            } while (temp != head);
        }

        void SearchByPriority()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            int p = int.Parse(Console.ReadLine());

            Node temp = head;
            bool found = false;

            do
            {
                if (temp.Priority == p)
                {
                    Console.WriteLine(temp.Id + " " + temp.Name);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("Not Found");
        }

        static void Main()
        {
            TaskScheduler t = new TaskScheduler();
            int ch;

            do
            {
                Console.WriteLine("\n1 AddBegin");
                Console.WriteLine("2 AddEnd");
                Console.WriteLine("3 AddPosition");
                Console.WriteLine("4 Remove");
                Console.WriteLine("5 ViewNext");
                Console.WriteLine("6 Display");
                Console.WriteLine("7 SearchByPriority");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) t.AddBegin();
                else if (ch == 2) t.AddEnd();
                else if (ch == 3) t.AddPosition();
                else if (ch == 4) t.Remove();
                else if (ch == 5) t.ViewNext();
                else if (ch == 6) t.Display();
                else if (ch == 7) t.SearchByPriority();

            } while (ch != 0);
        }
    }
}
