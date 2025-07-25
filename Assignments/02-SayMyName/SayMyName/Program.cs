namespace SayMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("Hello, please enter your name:");
            
            name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, nice to meet you!");

            Console.ReadLine();
        }
    }
}
