/*
Tim Rossiter
RCET2265
Fall 2025
https://github.com/rosstimo/SimpleCalculator.git
*/

using System;

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for user input and result
            int firstNumber;
            int secondNumber;
            string userResponse;
            int result;

            // Prompt the user for the first number
            Console.Write("Choose a Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // Prompt the user for the second number
            Console.Write("Choose a Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Present operation options to the user
            Console.WriteLine("Choose one of the following options:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Product");
            userResponse = Console.ReadLine();

            // Perform the selected operation and display the result
            if (userResponse == "1")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
            }
            else if (userResponse == "2")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
            }
            else
            {
                // Handle invalid option
                Console.WriteLine("Invalid option selected.");
            }

            // Prompt the user to press Enter to quit
            Console.WriteLine("Press Enter to quit...");
            Console.Read();
        }
    }
}
