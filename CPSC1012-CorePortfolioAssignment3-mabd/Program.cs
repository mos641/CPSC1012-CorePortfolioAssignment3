// File:    Program.cs
// Purpose: Determine whether the user answered the exam questions correctly

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_CorePortfolioAssignment3_mabd
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            int totalQuestions = 20;
            int questionNumber = 0;
            int totalWrong = 0;
            int totalRight = 0;
            int loopCounter = 0;
            char userChoice;

            // declare arrays
            char[] correctAnswers = new char[20] {'E', 'D', 'D', 'B', 'A', 'C', 'E', 'B', 'D', 'C', 'D', 'A', 'A', 'D', 'E', 'E', 'A', 'E', 'A', 'D'};
            char[] userAnswers = new char[totalQuestions];
            int[] wrongUserAnswers = new int[totalQuestions];

            // initial instructions
            Console.WriteLine("Enter the corresponding answers to the multiple choice questions provided.");
            Console.WriteLine("");

            // capture user answers into the array
            for (int index = 0; index < totalQuestions; index++)
            {
                questionNumber = index + 1;
                userChoice = InputOutput.QuestionChoice(questionNumber);
                userAnswers[index] = userChoice;
            }


            // check the user answers against the correct ones
            questionNumber = 0;
            while (loopCounter < totalQuestions)
            {
                questionNumber++;
                if (correctAnswers[loopCounter] != userAnswers[loopCounter])
                {
                    // populate last array with the question numbers of the incorrect answers
                    wrongUserAnswers[totalWrong] = questionNumber;
                    totalWrong++;
                }
                else
                {

                }
                loopCounter++;
            }

            // display pass/fail 
            totalRight = totalQuestions - totalWrong;
            if (totalRight >= 15)
            {
                // if they passed with 15 or more right answers
                Console.WriteLine("Passed with {0} correct answers.", totalRight);
            }
            else
            {
                // if they failed with more than 5 incorrect answers
                Console.WriteLine("Failed with {0} incorrect answers.", totalWrong);
                InputOutput.DisplayIncorrectQuestions(wrongUserAnswers, totalWrong);
            }

            // keep the console window open
            Console.ReadLine();
        }
    }
}
