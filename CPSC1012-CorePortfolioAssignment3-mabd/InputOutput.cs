// File:    InputOutput.cs
// Purpose: Capture input and display information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_CorePortfolioAssignment3_mabd
{
    class InputOutput
    {
        public static char QuestionChoice(int questionNumber)
        {
            // declare variables
            char charValue;
            bool inputIsValid = false;
            string errorMessage = "*** Invalid option.";

            // loop to determine whether char is valid menu choice
            do
            {
                // ask for and capture an char value
                    Console.Write("{0,3}. ", questionNumber);
                // loop to determine whether the input is a character
                while (!char.TryParse(Console.ReadLine().Trim().ToUpper(), out charValue))
                {
                    Console.WriteLine(errorMessage);
                    Console.Write("{0,3}. ", questionNumber);
                }
                if (!charValue.Equals('A') && !charValue.Equals('B') && !charValue.Equals('C') && !charValue.Equals('D') && !charValue.Equals('E'))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    inputIsValid = true;
                }
            } while (inputIsValid == false);

            return charValue;
        }

        public static void DisplayIncorrectQuestions(int[] integerArray, int logicalSize)
        {
            // declare variables
            int index = 0;

            // indicate that these are incorrect
            Console.Write("Incorrect questions:");

            // loop to print out incorrect question numbers
            for (index = 0; index < logicalSize; index++)
            {
                if (index < logicalSize - 1)
                {
                    Console.Write(" {0},", integerArray[index]);
                }
                else
                {
                    // print last value without comma
                    Console.WriteLine(" {0}", integerArray[logicalSize - 1]);
                }
            }
            

        }
    }
}
