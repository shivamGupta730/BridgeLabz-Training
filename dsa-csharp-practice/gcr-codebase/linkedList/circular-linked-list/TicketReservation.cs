using System;

namespace oops.Linkedlist
{
    internal class TicketReservation
    {
        class Node
        {
            public int TicketId;
            public string CustomerName;
            public string MovieName;
            public string SeatNo;
            public string BookingTime;
            public Node Next;

            public Node(int id, string c, string m, string s, string t)
            {
                TicketId = id;
                CustomerName = c;
                MovieName = m;
                SeatNo = s;
                BookingTime = t;
                Next = null;
            }
        }

        Node head = null;

        void AddTicket()
        {
            int id = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            string m = Console.ReadLine();
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            Node node = new Node(id, c, m, s, t);

            if (head == null)
            {
                head = node;
                node.Next = head;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = node;
            node.Next = head;
        }

        void RemoveTicket()
        {
            if (head == null)
            {
                Console.WriteLine("No Tickets");
                return;
            }

            int id = int.Parse(Console.ReadLine());

            if (head.TicketId == id && head.Next == head)
            {
                head = null;
                return;
            }

            if (head.TicketId == id)
            {
                Node temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                head = head.Next;
                temp.Next = head;
                return;
            }

            Node cur = head;
            while (cur.Next != head && cur.Next.TicketId != id)
                cur = cur.Next;

            if (cur.Next == head)
                Console.WriteLine("Ticket Not Found");
            else
                cur.Next = cur.Next.Next;
        }

        void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No Tickets");
                return;
            }

            Node temp = head;
            do
            {
                Console.WriteLine(
                    temp.TicketId + " " +
                    temp.CustomerName + " " +
                    temp.MovieName + " " +
                    temp.SeatNo + " " +
                    temp.BookingTime);

                temp = temp.Next;

            } while (temp != head);
        }

        void SearchTicket()
        {
            if (head == null)
            {
                Console.WriteLine("No Tickets");
                return;
            }

            Console.WriteLine("1 Customer Name  2 Movie Name");
            int ch = int.Parse(Console.ReadLine());

            Node temp = head;
            bool found = false;

            if (ch == 1)
            {
                string name = Console.ReadLine();
                do
                {
                    if (temp.CustomerName == name)
                    {
                        Console.WriteLine(temp.TicketId + " " + temp.MovieName + " " + temp.SeatNo);
                        found = true;
                    }
                    temp = temp.Next;
                } while (temp != head);
            }
            else
            {
                string movie = Console.ReadLine();
                do
                {
                    if (temp.MovieName == movie)
                    {
                        Console.WriteLine(temp.TicketId + " " + temp.CustomerName + " " + temp.SeatNo);
                        found = true;
                    }
                    temp = temp.Next;
                } while (temp != head);
            }

            if (!found)
                Console.WriteLine("Ticket Not Found");
        }

        void CountTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Tickets = 0");
                return;
            }

            int count = 0;
            Node temp = head;

            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("Total Tickets = " + count);
        }

        static void Main()
        {
            TicketReservation tr = new TicketReservation();
            int ch;

            do
            {
                Console.WriteLine("\n1 Add Ticket");
                Console.WriteLine("2 Remove Ticket");
                Console.WriteLine("3 Display Tickets");
                Console.WriteLine("4 Search Ticket");
                Console.WriteLine("5 Count Tickets");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) tr.AddTicket();
                else if (ch == 2) tr.RemoveTicket();
                else if (ch == 3) tr.DisplayTickets();
                else if (ch == 4) tr.SearchTicket();
                else if (ch == 5) tr.CountTickets();

            } while (ch != 0);
        }
    }
}
