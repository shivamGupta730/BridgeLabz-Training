using System;

namespace oops.Linkedlist
{
    internal class SocialMediaFriends
    {
        class FriendNode
        {
            public int FriendId;
            public FriendNode Next;

            public FriendNode(int id)
            {
                FriendId = id;
                Next = null;
            }
        }

        class UserNode
        {
            public int Id;
            public string Name;
            public int Age;
            public FriendNode Friends;
            public UserNode Next;

            public UserNode(int i, string n, int a)
            {
                Id = i;
                Name = n;
                Age = a;
                Friends = null;
                Next = null;
            }
        }

        UserNode head = null;

        void AddUser()
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            UserNode user = new UserNode(id, name, age);
            user.Next = head;
            head = user;
        }

        UserNode FindUser(int id)
        {
            UserNode temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        void AddFriend()
        {
            int u1 = int.Parse(Console.ReadLine());
            int u2 = int.Parse(Console.ReadLine());

            UserNode user1 = FindUser(u1);
            UserNode user2 = FindUser(u2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User Not Found");
                return;
            }

            FriendNode f1 = new FriendNode(u2);
            f1.Next = user1.Friends;
            user1.Friends = f1;

            FriendNode f2 = new FriendNode(u1);
            f2.Next = user2.Friends;
            user2.Friends = f2;
        }

        void RemoveFriend()
        {
            int u1 = int.Parse(Console.ReadLine());
            int u2 = int.Parse(Console.ReadLine());

            UserNode user1 = FindUser(u1);
            UserNode user2 = FindUser(u2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User Not Found");
                return;
            }

            RemoveFriendFromList(user1, u2);
            RemoveFriendFromList(user2, u1);
        }

        void RemoveFriendFromList(UserNode user, int fid)
        {
            FriendNode temp = user.Friends;

            if (temp == null) return;

            if (temp.FriendId == fid)
            {
                user.Friends = temp.Next;
                return;
            }

            while (temp.Next != null && temp.Next.FriendId != fid)
                temp = temp.Next;

            if (temp.Next != null)
                temp.Next = temp.Next.Next;
        }

        void DisplayFriends()
        {
            int id = int.Parse(Console.ReadLine());
            UserNode user = FindUser(id);

            if (user == null)
            {
                Console.WriteLine("User Not Found");
                return;
            }

            FriendNode temp = user.Friends;
            while (temp != null)
            {
                Console.WriteLine(temp.FriendId);
                temp = temp.Next;
            }
        }

        void SearchUser()
        {
            Console.WriteLine("1 By ID  2 By Name");
            int ch = int.Parse(Console.ReadLine());

            UserNode temp = head;

            if (ch == 1)
            {
                int id = int.Parse(Console.ReadLine());
                while (temp != null)
                {
                    if (temp.Id == id)
                    {
                        Console.WriteLine(temp.Name + " " + temp.Age);
                        return;
                    }
                    temp = temp.Next;
                }
            }
            else
            {
                string name = Console.ReadLine();
                while (temp != null)
                {
                    if (temp.Name == name)
                    {
                        Console.WriteLine(temp.Id + " " + temp.Age);
                        return;
                    }
                    temp = temp.Next;
                }
            }

            Console.WriteLine("User Not Found");
        }

        void CountFriends()
        {
            UserNode temp = head;

            while (temp != null)
            {
                int count = 0;
                FriendNode f = temp.Friends;

                while (f != null)
                {
                    count++;
                    f = f.Next;
                }

                Console.WriteLine(temp.Name + " Friends: " + count);
                temp = temp.Next;
            }
        }

        static void Main()
        {
            SocialMediaFriends sm = new SocialMediaFriends();
            int ch;

            do
            {
                Console.WriteLine("\n1 Add User");
                Console.WriteLine("2 Add Friend");
                Console.WriteLine("3 Remove Friend");
                Console.WriteLine("4 Display Friends");
                Console.WriteLine("5 Search User");
                Console.WriteLine("6 Count Friends");
                Console.WriteLine("0 Exit");

                ch = int.Parse(Console.ReadLine());

                if (ch == 1) sm.AddUser();
                else if (ch == 2) sm.AddFriend();
                else if (ch == 3) sm.RemoveFriend();
                else if (ch == 4) sm.DisplayFriends();
                else if (ch == 5) sm.SearchUser();
                else if (ch == 6) sm.CountFriends();

            } while (ch != 0);
        }
    }
}
