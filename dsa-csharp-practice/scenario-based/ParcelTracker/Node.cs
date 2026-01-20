namespace ParcelTracker
{
    class Node
    {
        public string Stage;
        public Node next;

        public Node(string stage)
        {
            Stage = stage;
            next = null;
        }
    }
}
