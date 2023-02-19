using System;

namespace QuestionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // number of questions
            Console.Write("How many questions do you want to answer (1-3)? ");
            int nQuestions = Convert.ToInt32(Console.ReadLine());

            // questions and answers
            for (int i = 0; i < nQuestions; i++)
            {
                Console.Write($"Question {i + 1}: ");

                // select question based on number
                switch (i + 1)
                {
                    case 1:
                        Console.Write("What is the airspeed velocity of an unladen swallow?");
                        CheckAnswer(Console.ReadLine(), "Which do you mean? African or Eurpoean");
                        break;
                    case 2:
                        Console.Write("What is the meaning of life");
                        CheckAnswer(Console.ReadLine(), "42");
                        break;
                    case 3:
                        Console.Write("what is your favorite color");
                        CheckAnswer(Console.ReadLine(), "Blue");
                        break;
                    default:
                        Console.WriteLine("Invalid. Please Retype");
                        break;
                }
            }
        }
        static void CheckAnswer(string userAnswer, string correctAnswer)
        {
            if (userAnswer.ToLower() == correctAnswer.ToLower())
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is {correctAnswer}.");
            }
        }
    }
}
