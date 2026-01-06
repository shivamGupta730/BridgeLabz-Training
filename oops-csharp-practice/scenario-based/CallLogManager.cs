using System;

namespace TelecomCallLogs
{
    // Single call log details
    class CallLog
    {
        public string PhoneNumber;
        public string Message;
        public DateTime TimeStamp;

        // Constructor
        public CallLog(string phoneNumber, string message, DateTime timeStamp)
        {
            PhoneNumber = phoneNumber;
            Message = message;
            TimeStamp = timeStamp;
        }

        // Display one call log
        public void Display()
        {
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("Message      : " + Message);
            Console.WriteLine("Time         : " + TimeStamp);
            Console.WriteLine("---------------------------");
        }
    }

    class CallLogManager
    {
        CallLog[] logs;
        int count = 0;

        // Constructor to set array size
        public CallLogManager(int size)
        {
            logs = new CallLog[size];
        }

        // Add new call log
        public void AddCallLog()
        {
            if (count >= logs.Length)
            {
                Console.WriteLine("Log storage full");
                return;
            }

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Message: ");
            string message = Console.ReadLine();

            DateTime time = DateTime.Now;

            logs[count] = new CallLog(phone, message, time);
            count++;

            Console.WriteLine("Call log added successfully");
        }

        // Search logs using keyword
        public void SearchByKeyword()
        {
            Console.Write("Enter keyword to search: ");
            string keyword = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    logs[i].Display();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching logs found");
            }
        }

        // Filter logs by time range
        public void FilterByTime()
        {
            Console.Write("Enter start date & time (yyyy-MM-dd HH:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter end date & time (yyyy-MM-dd HH:mm): ");
            DateTime end = DateTime.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
                {
                    logs[i].Display();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No logs found in given time range");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of call logs to store: ");
            int size = int.Parse(Console.ReadLine());

            CallLogManager manager = new CallLogManager(size);

            while (true)
            {
                Console.WriteLine("\n1. Add Call Log");
                Console.WriteLine("2. Search by Keyword");
                Console.WriteLine("3. Filter by Time");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddCallLog();
                        break;

                    case 2:
                        manager.SearchByKeyword();
                        break;

                    case 3:
                        manager.FilterByTime();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
