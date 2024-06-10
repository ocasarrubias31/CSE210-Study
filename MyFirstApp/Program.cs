using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LearnCSharp();
        }

        static void LearnCSharp()
        {
            Console.WriteLine("Welcome to learning C#!");
            int number = 5;
            string message = "The number is " + number;
            Console.WriteLine(message);

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
