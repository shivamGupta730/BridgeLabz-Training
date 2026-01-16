//using System;

//namespace basic.TrafficManager
//{
//    internal class TrafficUtility
//    {
//        // head of circular linked list
//        VehicleNode head = null;

//        // Add vehicle into roundabout
//        public void AddVehicle(int id)
//        {
//            VehicleNode newNode = new VehicleNode(id);

//            if (head == null)
//            {
//                head = newNode;
//                newNode.Next = head;
//                Console.WriteLine("Vehicle " + id + " entered roundabout");
//                return;
//            }

//            VehicleNode temp = head;
//            while (temp.Next != head)
//            {
//                temp = temp.Next;
//            }

//            temp.Next = newNode;
//            newNode.Next = head;

//            Console.WriteLine("Vehicle " + id + " entered roundabout");
//        }

//        // Remove vehicle from roundabout
//        public void RemoveVehicle()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Roundabout is empty");
//                return;
//            }

//            if (head.Next == head)
//            {
//                Console.WriteLine("Vehicle " + head.VehicleId + " exited");
//                head = null;
//                return;
//            }

//            VehicleNode temp = head;
//            while (temp.Next.Next != head)
//            {
//                temp = temp.Next;
//            }

//            Console.WriteLine("Vehicle " + temp.Next.VehicleId + " exited");
//            temp.Next = head;
//        }

//        // Display current state of roundabout
//        public void DisplayRoundabout()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("Roundabout is empty");
//                return;
//            }

//            VehicleNode temp = head;
//            Console.Write("Roundabout State: ");

//            do
//            {
//                Console.Write(temp.VehicleId + " -> ");
//                temp = temp.Next;
//            }
//            while (temp != head);

//            Console.WriteLine("START");
//        }
//    }
//}
