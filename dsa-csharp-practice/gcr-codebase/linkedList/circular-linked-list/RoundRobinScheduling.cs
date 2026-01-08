using System;

namespace oops.Linkedlist
{
    internal class RoundRobinScheduling
    {
        class Node
        {
            public int Pid;
            public int Burst;
            public int Remaining;
            public Node Next;

            public Node(int p, int b)
            {
                Pid = p;
                Burst = b;
                Remaining = b;
                Next = null;
            }
        }

        Node head = null;

        void AddProcess()
        {
            int p = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Node node = new Node(p, b);

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

        void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            Node temp = head;
            do
            {
                Console.WriteLine("PID: " + temp.Pid + " Remaining: " + temp.Remaining);
                temp = temp.Next;
            } while (temp != head);
        }

        void Schedule()
        {
            if (head == null)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            Console.Write("Time Quantum: ");
            int tq = int.Parse(Console.ReadLine());

            int time = 0;
            int totalWT = 0;
            int totalTAT = 0;
            int count = Count();

            Node temp = head;
            Node prev = null;

            while (head != null)
            {
                if (temp.Remaining > tq)
                {
                    temp.Remaining -= tq;
                    time += tq;
                }
                else
                {
                    time += temp.Remaining;
                    totalWT += time - temp.Burst;
                    totalTAT += time;

                    Remove(temp.Pid);

                    if (head == null)
                        break;

                    temp = head;
                    continue;
                }

                prev = temp;
                temp = temp.Next;
            }

            Console.WriteLine("Average Waiting Time = " + (double)totalWT / count);
            Console.WriteLine("Average Turnaround Time = " + (double)totalTAT / count);
        }

        void Remove(int pid)
        {
            if (head == null) return;

            if (head.Pid == pid && head.Next == head)
            {
                head = null;
                return;
            }

            if (head.Pid == pid)
            {
                Node temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                head = head.Next;
                temp.Next = head;
                return;
            }

            Node cur = head;
            while (cur.Next != head && cur.Next.Pid != pid)
                cur = cur.Next;

            if (cur.Next.Pid == pid)
                cur.Next = cur.Next.Next;
        }

        int Count()
        {
            if (head == null) return 0;

            int c = 0;
            Node temp = head;
            do
            {
                c++;
                temp = temp.Next;
            } while (temp != head);

            return c;
        }

        static void Main()
        {
            RoundRobinScheduling rr = new RoundRobinScheduling();
            int ch;

            do
            {
                Console.WriteLine("\n1 Add Process");
                Console.WriteLine("2 Display Queue");
                Console.WriteLine("3 Run Scheduler");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) rr.AddProcess();
                else if (ch == 2) rr.Display();
                else if (ch == 3) rr.Schedule();

            } while (ch != 0);
        }
    }
}
