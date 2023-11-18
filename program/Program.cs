using System;

namespace GreetingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple greeting program
            Console.WriteLine("Hello, welcome to the Greeting Project!");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Display a personalized greeting
            Console.WriteLine($"Hello, {userName}! Nice to meet you.");

            // Wait for user input to exit
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
