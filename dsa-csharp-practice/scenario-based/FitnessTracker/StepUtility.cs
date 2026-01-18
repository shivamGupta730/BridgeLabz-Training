using System;

namespace basic.FitnessTracker
{
    internal class StepUtility : IStepSort
    {
        UserSteps[] users;
        int size;

        public StepUtility(int size)
        {
            this.size = size;
            users = new UserSteps[size];

            for (int i = 0; i < size; i++)
            {
                users[i] = new UserSteps();
            }
        }

        // input daily steps
        public void AddSteps()
        {
            Console.WriteLine("Enter daily steps:");
            for (int i = 0; i < size; i++)
            {
                users[i].Steps = int.Parse(Console.ReadLine());
            }
        }

        // bubble sort logic
        public void Sort()
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    // higher steps first
                    if (users[j].Steps < users[j + 1].Steps)
                    {
                        int temp = users[j].Steps;
                        users[j].Steps = users[j + 1].Steps;
                        users[j + 1].Steps = temp;
                    }
                }
            }
        }

        // display ranking
        public void Display()
        {
            Console.WriteLine("Daily Step Ranking:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(users[i].Steps + " ");
            }
        }
    }
}
