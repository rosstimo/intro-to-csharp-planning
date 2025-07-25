// This program simulates rolling two six-sided dice 1,000 times and counts the results.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] rollCounts = new int[13]; // Index 0 and 1 will remain unused
        Random random = new Random();

        for (int i = 0; i < 1000; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;
            rollCounts[sum]++;
        }

        Console.WriteLine("Roll Result Counts:");
        Console.WriteLine("Result\tCount");

        for (int i = 2; i <= 12; i++)
        {
            Console.WriteLine($"{i}\t{rollCounts[i]}");
        }
    }
}
