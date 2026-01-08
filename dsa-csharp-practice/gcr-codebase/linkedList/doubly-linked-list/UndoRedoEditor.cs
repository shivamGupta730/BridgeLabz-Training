using System;

namespace oops.Linkedlist
{
    internal class UndoRedoEditor
    {
        class Node
        {
            public string Text;
            public Node Prev;
            public Node Next;

            public Node(string t)
            {
                Text = t;
                Prev = null;
                Next = null;
            }
        }

        Node head = null;
        Node tail = null;
        Node current = null;
        int size = 0;
        const int MAX = 10;

        void AddState()
        {
            string text = Console.ReadLine();
            Node node = new Node(text);

            if (head == null)
            {
                head = tail = current = node;
                size = 1;
                return;
            }

            if (current.Next != null)
            {
                current.Next.Prev = null;
                current.Next = null;
                tail = current;
            }

            tail.Next = node;
            node.Prev = tail;
            tail = node;
            current = node;
            size++;

            if (size > MAX)
            {
                head = head.Next;
                head.Prev = null;
                size--;
            }
        }

        void Undo()
        {
            if (current == null || current.Prev == null)
            {
                Console.WriteLine("Nothing to Undo");
                return;
            }

            current = current.Prev;
        }

        void Redo()
        {
            if (current == null || current.Next == null)
            {
                Console.WriteLine("Nothing to Redo");
                return;
            }

            current = current.Next;
        }

        void Show()
        {
            if (current == null)
            {
                Console.WriteLine("Empty");
                return;
            }

            Console.WriteLine("Current Text: " + current.Text);
        }

        static void Main()
        {
            UndoRedoEditor ed = new UndoRedoEditor();
            int ch;

            do
            {
                Console.WriteLine("\n1 Add Text");
                Console.WriteLine("2 Undo");
                Console.WriteLine("3 Redo");
                Console.WriteLine("4 Show");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) ed.AddState();
                else if (ch == 2) ed.Undo();
                else if (ch == 3) ed.Redo();
                else if (ch == 4) ed.Show();

            } while (ch != 0);
        }
    }
}
