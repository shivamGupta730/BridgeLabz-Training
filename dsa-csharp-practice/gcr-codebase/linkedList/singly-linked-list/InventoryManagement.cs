using System;

namespace oops.Linkedlist
{
    internal class InventoryManagement
    {
        class Node
        {
            public int Id;
            public string Name;
            public int Qty;
            public double Price;
            public Node Next;

            public Node(int i, string n, int q, double p)
            {
                Id = i;
                Name = n;
                Qty = q;
                Price = p;
                Next = null;
            }
        }

        Node head = null;

        void AddBegin()
        {
            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int q = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            Node node = new Node(i, n, q, p);
            node.Next = head;
            head = node;
        }

        void AddEnd()
        {
            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int q = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            Node node = new Node(i, n, q, p);

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

        void AddPosition()
        {
            int pos = int.Parse(Console.ReadLine());

            int i = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            int q = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            Node node = new Node(i, n, q, p);

            if (pos == 1)
            {
                node.Next = head;
                head = node;
                return;
            }

            Node temp = head;
            for (int c = 1; c < pos - 1 && temp != null; c++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

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

            if (head.Id == id)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Id != id)
                temp = temp.Next;

            if (temp.Next == null)
                Console.WriteLine("Not Found");
            else
                temp.Next = temp.Next.Next;
        }

        void UpdateQty()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            int id = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            Node temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                {
                    temp.Qty = q;
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Not Found");
        }

        void Search()
        {
            if (head == null)
            {
                Console.WriteLine("List Empty");
                return;
            }

            Console.WriteLine("1 By ID  2 By Name");
            int ch = int.Parse(Console.ReadLine());

            Node temp = head;

            if (ch == 1)
            {
                int id = int.Parse(Console.ReadLine());
                while (temp != null)
                {
                    if (temp.Id == id)
                    {
                        Console.WriteLine(temp.Name + " " + temp.Qty + " " + temp.Price);
                        return;
                    }
                    temp = temp.Next;
                }
            }
            else
            {
                string n = Console.ReadLine();
                while (temp != null)
                {
                    if (temp.Name == n)
                        Console.WriteLine(temp.Id + " " + temp.Qty + " " + temp.Price);
                    temp = temp.Next;
                }
            }

            Console.WriteLine("Not Found");
        }

        void TotalValue()
        {
            double sum = 0;
            Node temp = head;

            while (temp != null)
            {
                sum += temp.Price * temp.Qty;
                temp = temp.Next;
            }

            Console.WriteLine("Total Value = " + sum);
        }

        void Sort()
        {
            if (head == null) return;

            Console.WriteLine("1 Name  2 Price");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("1 Asc  2 Desc");
            int o = int.Parse(Console.ReadLine());

            for (Node i = head; i.Next != null; i = i.Next)
            {
                for (Node j = i.Next; j != null; j = j.Next)
                {
                    bool swap = false;

                    if (f == 1)
                        swap = o == 1 ? i.Name.CompareTo(j.Name) > 0 : i.Name.CompareTo(j.Name) < 0;
                    else
                        swap = o == 1 ? i.Price > j.Price : i.Price < j.Price;

                    if (swap)
                    {
                        (i.Id, j.Id) = (j.Id, i.Id);
                        (i.Name, j.Name) = (j.Name, i.Name);
                        (i.Qty, j.Qty) = (j.Qty, i.Qty);
                        (i.Price, j.Price) = (j.Price, i.Price);
                    }
                }
            }
        }

        static void Main()
        {
            InventoryManagement im = new InventoryManagement();
            int ch;

            do
            {
                Console.WriteLine("\n1 AddBegin");
                Console.WriteLine("2 AddEnd");
                Console.WriteLine("3 AddPosition");
                Console.WriteLine("4 Remove");
                Console.WriteLine("5 UpdateQty");
                Console.WriteLine("6 Search");
                Console.WriteLine("7 TotalValue");
                Console.WriteLine("8 Sort");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) im.AddBegin();
                else if (ch == 2) im.AddEnd();
                else if (ch == 3) im.AddPosition();
                else if (ch == 4) im.Remove();
                else if (ch == 5) im.UpdateQty();
                else if (ch == 6) im.Search();
                else if (ch == 7) im.TotalValue();
                else if (ch == 8) im.Sort();

            } while (ch != 0);
        }
    }
}
