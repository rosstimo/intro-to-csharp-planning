// This program accumulates messages entered by the user.
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder accumulatedMessages = new StringBuilder();
        string input;

        Console.WriteLine("Enter messages to accumulate. Type 'exit' to stop.");

        do
        {
            Console.Write("Enter a message: ");
            input = Console.ReadLine();

            if (input.ToLower() != "exit")
            {
                accumulatedMessages.AppendLine(input);
            }

        } while (input.ToLower() != "exit");

        Console.WriteLine("\nAccumulated Messages:");
        Console.WriteLine(accumulatedMessages.ToString());

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}
