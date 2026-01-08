using System;

namespace oops.Linkedlist
{
    internal class MovieManagement
    {
        class Node
        {
            public string Title;
            public string Director;
            public int Year;
            public double Rating;
            public Node Next;
            public Node Prev;

            public Node(string t, string d, int y, double r)
            {
                Title = t;
                Director = d;
                Year = y;
                Rating = r;
                Next = null;
                Prev = null;
            }
        }

        Node head = null;

        void AddBegin()
        {
            string t = Console.ReadLine();
            string d = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());

            Node node = new Node(t, d, y, r);

            if (head != null)
            {
                node.Next = head;
                head.Prev = node;
            }

            head = node;
        }

        void AddEnd()
        {
            string t = Console.ReadLine();
            string d = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());

            Node node = new Node(t, d, y, r);

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

            string t = Console.ReadLine();
            string d = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());

            Node node = new Node(t, d, y, r);

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

        void RemoveByTitle()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            string title = Console.ReadLine();

            Node temp = head;

            if (head.Title == title)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                return;
            }

            while (temp != null && temp.Title != title)
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
                Console.WriteLine("List Empty");
                return;
            }

            Console.WriteLine("1 Director  2 Rating");
            int ch = int.Parse(Console.ReadLine());

            Node temp = head;

            if (ch == 1)
            {
                string d = Console.ReadLine();
                while (temp != null)
                {
                    if (temp.Director == d)
                        Console.WriteLine(temp.Title + " " + temp.Rating);
                    temp = temp.Next;
                }
            }
            else
            {
                double r = double.Parse(Console.ReadLine());
                while (temp != null)
                {
                    if (temp.Rating == r)
                        Console.WriteLine(temp.Title + " " + temp.Director);
                    temp = temp.Next;
                }
            }
        }

        void UpdateRating()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            string t = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());

            Node temp = head;
            while (temp != null)
            {
                if (temp.Title == t)
                {
                    temp.Rating = r;
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
                Console.WriteLine(temp.Title + " " + temp.Director + " " + temp.Year + " " + temp.Rating);
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
                Console.WriteLine(temp.Title + " " + temp.Director + " " + temp.Year + " " + temp.Rating);
                temp = temp.Prev;
            }
        }

        static void Main()
        {
            MovieManagement m = new MovieManagement();
            int ch;

            do
            {
                Console.WriteLine("\n1 AddBegin");
                Console.WriteLine("2 AddEnd");
                Console.WriteLine("3 AddPosition");
                Console.WriteLine("4 Remove");
                Console.WriteLine("5 Search");
                Console.WriteLine("6 UpdateRating");
                Console.WriteLine("7 DisplayForward");
                Console.WriteLine("8 DisplayReverse");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) m.AddBegin();
                else if (ch == 2) m.AddEnd();
                else if (ch == 3) m.AddPosition();
                else if (ch == 4) m.RemoveByTitle();
                else if (ch == 5) m.Search();
                else if (ch == 6) m.UpdateRating();
                else if (ch == 7) m.DisplayForward();
                else if (ch == 8) m.DisplayReverse();

            } while (ch != 0);
        }
    }
}
