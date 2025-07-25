// This program generates a random fortune message for the user.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Array of fortune messages
        string[] fortunes = {
            "You will have a great day!",
            "A surprise is waiting for you around the corner.",
            "Happiness is coming your way.",
            "Be cautious of new opportunities.",
            "You will achieve your goals soon.",
            "An old friend will reconnect with you.",
            "Success is in your future.",
            "Take time to relax and enjoy life."
        };

        // Generate a random index
        Random random = new Random();
        int index = random.Next(fortunes.Length);

        // Display the fortune message
        Console.WriteLine("Your fortune: " + fortunes[index]);
    }
}
