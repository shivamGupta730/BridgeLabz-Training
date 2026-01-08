using System;

namespace oops.Linkedlist
{
    internal class LibraryManagement
    {
        class Node
        {
            public int BookId;
            public string Title;
            public string Author;
            public string Genre;
            public bool Available;
            public Node Next;
            public Node Prev;

            public Node(int id, string t, string a, string g, bool av)
            {
                BookId = id;
                Title = t;
                Author = a;
                Genre = g;
                Available = av;
                Next = null;
                Prev = null;
            }
        }

        Node head = null;

        void AddBegin()
        {
            int id = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string a = Console.ReadLine();
            string g = Console.ReadLine();
            bool av = bool.Parse(Console.ReadLine());

            Node node = new Node(id, t, a, g, av);

            if (head != null)
            {
                node.Next = head;
                head.Prev = node;
            }

            head = node;
        }

        void AddEnd()
        {
            int id = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string a = Console.ReadLine();
            string g = Console.ReadLine();
            bool av = bool.Parse(Console.ReadLine());

            Node node = new Node(id, t, a, g, av);

            if (head == null)
            {
                head = node;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = node;
            node.Prev = temp;
        }

        void AddPosition()
        {
            int pos = int.Parse(Console.ReadLine());

            int id = int.Parse(Console.ReadLine());
            string t = Console.ReadLine();
            string a = Console.ReadLine();
            string g = Console.ReadLine();
            bool av = bool.Parse(Console.ReadLine());

            Node node = new Node(id, t, a, g, av);

            if (pos == 1)
            {
                AddBegin();
                return;
            }

            Node temp = head;
            for (int i = 1; i < pos - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            node.Next = temp.Next;
            node.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = node;

            temp.Next = node;
        }

        void Remove()
        {
            if (head == null)
            {
                Console.WriteLine("Library Empty");
                return;
            }

            int id = int.Parse(Console.ReadLine());

            if (head.BookId == id)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                return;
            }

            Node temp = head;
            while (temp != null && temp.BookId != id)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Not Found");
                return;
            }

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;
        }

        void Search()
        {
            if (head == null)
            {
                Console.WriteLine("Library Empty");
                return;
            }

            Console.WriteLine("1 Title  2 Author");
            int ch = int.Parse(Console.ReadLine());

            Node temp = head;

            if (ch == 1)
            {
                string t = Console.ReadLine();
                while (temp != null)
                {
                    if (temp.Title == t)
                        Console.WriteLine(temp.BookId + " " + temp.Author + " " + temp.Available);
                    temp = temp.Next;
                }
            }
            else
            {
                string a = Console.ReadLine();
                while (temp != null)
                {
                    if (temp.Author == a)
                        Console.WriteLine(temp.BookId + " " + temp.Title + " " + temp.Available);
                    temp = temp.Next;
                }
            }
        }

        void UpdateAvailability()
        {
            if (head == null)
            {
                Console.WriteLine("Library Empty");
                return;
            }

            int id = int.Parse(Console.ReadLine());
            bool av = bool.Parse(Console.ReadLine());

            Node temp = head;
            while (temp != null)
            {
                if (temp.BookId == id)
                {
                    temp.Available = av;
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Not Found");
        }

        void DisplayForward()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.BookId + " " + temp.Title + " " + temp.Author + " " + temp.Available);
                temp = temp.Next;
            }
        }

        void DisplayReverse()
        {
            if (head == null) return;

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            while (temp != null)
            {
                Console.WriteLine(temp.BookId + " " + temp.Title + " " + temp.Author + " " + temp.Available);
                temp = temp.Prev;
            }
        }

        void CountBooks()
        {
            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            Console.WriteLine("Total Books = " + count);
        }

        static void Main()
        {
            LibraryManagement l = new LibraryManagement();
            int ch;

            do
            {
                Console.WriteLine("\n1 AddBegin");
                Console.WriteLine("2 AddEnd");
                Console.WriteLine("3 AddPosition");
                Console.WriteLine("4 Remove");
                Console.WriteLine("5 Search");
                Console.WriteLine("6 UpdateAvailability");
                Console.WriteLine("7 DisplayForward");
                Console.WriteLine("8 DisplayReverse");
                Console.WriteLine("9 CountBooks");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) l.AddBegin();
                else if (ch == 2) l.AddEnd();
                else if (ch == 3) l.AddPosition();
                else if (ch == 4) l.Remove();
                else if (ch == 5) l.Search();
                else if (ch == 6) l.UpdateAvailability();
                else if (ch == 7) l.DisplayForward();
                else if (ch == 8) l.DisplayReverse();
                else if (ch == 9) l.CountBooks();

            } while (ch != 0);
        }
    }
}
