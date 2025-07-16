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
            Console.WriteLine("Better Calculator\n");
            while (true)
            {
                int num1, num2;
                if (!PromptForNumber("Choose a Number", out num1)) break;
                if (!PromptForNumber("Choose a Number", out num2)) break;

                int operation = PromptForOperation();
                if (operation == -1) break;

                int result = 0;
                string opSymbol = "";
                bool valid = true;
                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        opSymbol = "+";
                        break;
                    case 2:
                        result = num1 - num2;
                        opSymbol = "-";
                        break;
                    case 3:
                        result = num1 * num2;
                        opSymbol = "*";
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            valid = false;
                        }
                        else
                        {
                            result = num1 / num2;
                            opSymbol = "/";
                        }
                        break;
                    default:
                        valid = false;
                        break;
                }
                if (valid && opSymbol != "")
                {
                    Console.WriteLine($"{num1} {opSymbol} {num2} = {result}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Have a nice day");
            Console.WriteLine("Press enter to close this window");
            Console.ReadLine();
        }

        static bool PromptForNumber(string prompt, out int number)
        {
            number = 0;
            while (true)
            {
                Console.Write($"{prompt}: ");
                string input = Console.ReadLine();
                if (input.Trim().ToUpper() == "Q")
                {
                    Console.WriteLine($"You entered \"{input}\"");
                    return false;
                }
                if (int.TryParse(input, out number))
                {
                    Console.WriteLine($"You entered \"{number}\"");
                    return true;
                }
                else
                {
                    Console.WriteLine($"You entered \"{input}\", please enter a whole number.");
                }
            }
        }

        static int PromptForOperation()
        {
            while (true)
            {
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                string input = Console.ReadLine();
                if (input.Trim().ToUpper() == "Q")
                {
                    Console.WriteLine($"You entered \"{input}\"");
                    return -1;
                }
                if (int.TryParse(input, out int op) && op >= 1 && op <= 4)
                {
                    Console.WriteLine($"You entered \"{op}\"");
                    return op;
                }
                else
                {
                    Console.WriteLine($"You entered \"{input}\", please enter a valid option (1-4).");
                }
            }
        }
    }
}
