using System;
using System.Collections.Generic;

namespace ExamProctor
{
    class ExamService
    {
        private Stack<int> navigation = new Stack<int>();
        private Dictionary<int, string> answers = new Dictionary<int, string>();

        public void VisitQuestion(int qId)
        {
            navigation.Push(qId);
        }

        public void SubmitAnswer(int qId, string answer)
        {
            answers[qId] = answer;
        }

        public int CalculateScore(Dictionary<int, string> correct)
        {
            int score = 0;

            foreach (var item in correct)
            {
                if (answers.ContainsKey(item.Key) &&
                    answers[item.Key] == item.Value)
                    score++;
            }
            return score;
        }

        public void ShowNavigation()
        {
            Console.WriteLine("Navigation History:");
            foreach (int q in navigation)
                Console.WriteLine("Question " + q);
        }
    }
}
