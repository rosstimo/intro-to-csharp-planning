// This program converts a string to an integer and validates the conversion.
// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int result;

        Console.WriteLine("Enter numbers to convert. Type 'exit' to stop.");

        do
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();

            if (input.ToLower() != "exit")
            {
                if (TryConvertToInt(input, out result))
                {
                    Console.WriteLine($"Conversion successful: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid number. Please try again.");
                }
            }

        } while (input.ToLower() != "exit");

        Console.WriteLine("Goodbye!");
    }

    static bool TryConvertToInt(string value, out int number)
    {
        return int.TryParse(value, out number);
    }
}
