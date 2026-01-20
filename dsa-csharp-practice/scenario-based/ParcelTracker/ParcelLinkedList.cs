using System;

namespace ParcelTracker
{
    class ParcelLinkedList
    {
        private Node head;

        // Add stage at end
        public void AddStage(string stage)
        {
            Node newNode = new Node(stage);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
                temp = temp.next;

            temp.next = newNode;
        }

        // Add checkpoint after a stage
        public void AddCheckpoint(string afterStage, string newStage)
        {
            Node temp = head;

            while (temp != null && temp.Stage != afterStage)
                temp = temp.next;

            if (temp == null)
            {
                Console.WriteLine("Stage not found (Parcel may be lost)");
                return;
            }

            Node node = new Node(newStage);
            node.next = temp.next;
            temp.next = node;
        }

        // Forward tracking
        public void TrackParcel()
        {
            if (head == null)
            {
                Console.WriteLine("Parcel missing (null)");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Stage + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("END");
        }
    }
}
