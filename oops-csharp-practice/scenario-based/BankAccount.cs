using System;

namespace BridgeLabzTraining.scenrio_based_problem
{
    internal class BankAccount
    {
        // account data
        public int AccountNumber;
        public int Pin;
        public double Balance;

        // account setup
        public void SetAccount(int accNo, int pin, double balance)
        {
            AccountNumber = accNo;
            Pin = pin;
            Balance = balance;
        }

        // deposit
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposit successful");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        // withdraw
        public void Withdraw(double amount)
        {
            // overdraft allowed nahi
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        // balance check
        public void CheckBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }

        // ================= MAIN METHOD =================
        static void Main(string[] args)
        {

            BankAccount[] accounts = new BankAccount[10];
            int accountCount = 0;

            while (true)
            {
                Console.WriteLine("\n1. Admin");
                Console.WriteLine("2. Client");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                int role;
                if (!int.TryParse(Console.ReadLine(), out role))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (role == 3)
                {
                    Console.WriteLine("Program exited");
                    break;
                }

                // ================= ADMIN =================
                if (role == 1)
                {
                    Console.WriteLine("\nADMIN MENU");
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. View All Accounts");
                    Console.WriteLine("3. View Single Account");
                    Console.Write("Enter choice: ");

                    int adminChoice;
                    if (!int.TryParse(Console.ReadLine(), out adminChoice))
                    {
                        Console.WriteLine("Invalid choice");
                        continue;
                    }

                    // ---- Create Account ----
                    if (adminChoice == 1)
                    {
                        if (accountCount >= accounts.Length)
                        {
                            Console.WriteLine("Account limit reached");
                            continue;
                        }

                        Console.Write("Enter 6 digit account number: ");
                        int accNo = Convert.ToInt32(Console.ReadLine());

                        // account number validation
                        if (accNo < 100000 || accNo > 999999)
                        {
                            Console.WriteLine("Invalid account number");
                            continue;
                        }

                        // duplicate account check
                        bool exists = false;
                        for (int i = 0; i < accountCount; i++)
                        {
                            if (accounts[i].AccountNumber == accNo)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Account already exists");
                            continue;
                        }

                        Console.Write("Set 4 digit PIN: ");
                        int pin = Convert.ToInt32(Console.ReadLine());

                        // pin validation
                        if (pin < 1000 || pin > 9999)
                        {
                            Console.WriteLine("Invalid PIN");
                            continue;
                        }

                        Console.Write("Enter initial balance: ");
                        double bal = Convert.ToDouble(Console.ReadLine());

                        BankAccount acc = new BankAccount();
                        acc.SetAccount(accNo, pin, bal);

                        accounts[accountCount] = acc;
                        accountCount++;

                        Console.WriteLine("Account created successfully");
                    }

                    // ---- View All Accounts ----
                    else if (adminChoice == 2)
                    {
                        if (accountCount == 0)
                        {
                            Console.WriteLine("No accounts available");
                            continue;
                        }

                        Console.WriteLine("\nALL ACCOUNTS:");
                        for (int i = 0; i < accountCount; i++)
                        {
                            Console.WriteLine("Account No: " + accounts[i].AccountNumber +
                                               " | Balance: " + accounts[i].Balance);
                        }
                    }

                    // ---- View Single Account ----
                    else if (adminChoice == 3)
                    {
                        Console.Write("Enter account number: ");
                        int accNo = Convert.ToInt32(Console.ReadLine());

                        bool found = false;
                        for (int i = 0; i < accountCount; i++)
                        {
                            if (accounts[i].AccountNumber == accNo)
                            {
                                Console.WriteLine("Account No: " + accounts[i].AccountNumber);
                                Console.WriteLine("Balance   : " + accounts[i].Balance);
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                            Console.WriteLine("Account not found");
                    }
                    else
                    {
                        Console.WriteLine("Invalid admin option");
                    }
                }

                // ================= CLIENT =================
                else if (role == 2)
                {
                    Console.Write("Enter account number: ");
                    int accNo = Convert.ToInt32(Console.ReadLine());

                    BankAccount foundAccount = null;

                    for (int i = 0; i < accountCount; i++)
                    {
                        if (accounts[i].AccountNumber == accNo)
                        {
                            foundAccount = accounts[i];
                            break;
                        }
                    }

                    if (foundAccount == null)
                    {
                        Console.WriteLine("Account not found");
                        continue;
                    }

                    Console.Write("Enter PIN: ");
                    int pin = Convert.ToInt32(Console.ReadLine());

                    if (foundAccount.Pin != pin)
                    {
                        Console.WriteLine("Incorrect PIN");
                        continue;
                    }

                    Console.WriteLine("\nCLIENT MENU");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.Write("Enter choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Enter amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        foundAccount.Deposit(amt);
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        foundAccount.Withdraw(amt);
                    }
                    else if (choice == 3)
                    {
                        foundAccount.CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
            }
        }
    }
}
