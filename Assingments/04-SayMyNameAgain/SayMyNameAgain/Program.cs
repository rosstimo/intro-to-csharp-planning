/*
Tim Rossiter
RCET2265
Fall 2025
Say My Name Again
https://github.com/rosstimo/say-my-name-again.git
*/

using System;

namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Greet the user by name or with a special message
            if (userName.ToLower() == "emily")
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            else if (userName.ToLower() == "joe")
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            else if (userName.ToLower() == "tim")
            {
                Console.WriteLine($"Hey, that's me! Welcome, {userName}!");
            }
            else
            {
                Console.WriteLine($"Hello, {userName}! Nice to meet you.");
            }

            // Prompt the user to press Enter to quit
            Console.WriteLine("Press Enter to quit...");
            Console.Read();
        }
    }
}
