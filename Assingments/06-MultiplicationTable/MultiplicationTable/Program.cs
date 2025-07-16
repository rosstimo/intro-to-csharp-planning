// -----------------------------------------------------------------------------
// Name:        Your Name
// Class:       RCET 2265
// Assignment:  06-MultiplicationTable
// Date:        2025-07-16
// Description: Displays a multiplication table for numbers 1 through 12 (or user-specified size).
// -----------------------------------------------------------------------------
using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set default table size
            int tableSize = 12;
            Console.WriteLine("Multiplication Table\n");
            Console.Write("Enter table size (press Enter for 12): ");
            string input = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!int.TryParse(input, out tableSize) || tableSize < 1)
                {
                    Console.WriteLine("Invalid input. Using default size 12.");
                    tableSize = 12;
                }
            }

            // Print header row
            //Console.Write("    ");
            for (int column = 1; column <= tableSize; column++)
            {
                Console.Write($"{column,4}");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 4 * (tableSize)));

            // Print table rows
            for (int row = 1; row <= tableSize; row++)
            {
                //Console.Write($"{row,3}");
                for (int col = 1; col <= tableSize; col++)
                {
                    Console.Write($"{row * col,4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPress Enter to close the window.");
            Console.ReadLine();
        }
    }
}
