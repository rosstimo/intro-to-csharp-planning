// -----------------------------------------------------------------------------
// Name:        Your Name
// Class:       RCET 2265
// Assignment:  05-BetterCalculator
// Date:        2025-07-16
// Description: A better calculator that validates input, supports quitting, and
//              performs basic arithmetic operations in a loop.
// -----------------------------------------------------------------------------
using System;

namespace BetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main control variable for the calculator loop
            bool keepRunning = true;
            // Variables for user input and calculation
            int firstNumber = 0;
            int secondNumber = 0;
            string userInput = "";
            int operation = 0;
            int result = 0;
            string operationSymbol = "";
            bool validInput = false;
            bool valid = true;

            Console.WriteLine("Welcome to the Better Calculator...\n");
            do
            {
                // Reset control variables for each calculation
                keepRunning = true;
                validInput = false;
                // Prompt for the first number
                while (!validInput && keepRunning)
                {
                    Console.Write("Choose a Number: ");
                    userInput = Console.ReadLine() ?? "";
                    // Allow user to quit
                    if (userInput.Trim().ToUpper() == "Q")
                    {
                        Console.WriteLine($"You entered \"{userInput}\"");
                        keepRunning = false;
                    }
                    // Validate input as integer
                    else if (int.TryParse(userInput, out firstNumber))
                    {
                        Console.WriteLine($"You entered \"{firstNumber}\"");
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"You entered \"{userInput}\", please enter a whole number.");
                    }
                }

                // Prompt for the second number
                validInput = false;
                while (!validInput && keepRunning)
                {
                    Console.Write("Choose a Number: ");
                    userInput = Console.ReadLine() ?? "";
                    // Allow user to quit
                    if (userInput.Trim().ToUpper() == "Q")
                    {
                        Console.WriteLine($"You entered \"{userInput}\"");
                        keepRunning = false;
                    }
                    // Validate input as integer
                    else if (int.TryParse(userInput, out secondNumber))
                    {
                        Console.WriteLine($"You entered \"{secondNumber}\"");
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"You entered \"{userInput}\", please enter a whole number.");
                    }
                }

                // Prompt for the operation
                validInput = false;
                while (!validInput && keepRunning)
                {
                    Console.WriteLine("Choose one of the following options:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    userInput = Console.ReadLine() ?? "";
                    // Allow user to quit
                    if (userInput.Trim().ToUpper() == "Q")
                    {
                        Console.WriteLine($"You entered \"{userInput}\"");
                        keepRunning = false;
                    }
                    // Validate input as integer and within range
                    else if (int.TryParse(userInput, out operation) && operation >= 1 && operation <= 4)
                    {
                        Console.WriteLine($"You entered \"{operation}\"");
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"You entered \"{userInput}\", please enter a valid option (1-4).");
                    }
                }

                // Perform the selected operation
                result = 0;
                operationSymbol = "";
                valid = true;
                switch (operation)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        operationSymbol = "+";
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        operationSymbol = "-";
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        operationSymbol = "*";
                        break;
                    case 4:
                        // Handle division by zero
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            valid = false;
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            operationSymbol = "/";
                        }
                        break;
                    default:
                        valid = false;
                        break;
                }
                // Display the result if valid
                if (valid && operationSymbol != "")
                {
                    Console.WriteLine($"{firstNumber} {operationSymbol} {secondNumber} = {result}");
                }
                Console.WriteLine();
            } while (keepRunning);
            Console.WriteLine("Have a nice day");
            Console.WriteLine("Press enter to close this window");
            Console.ReadLine();
        }
    }
}
