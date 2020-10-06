using System;

namespace GettingInput
{
    class Program
    {
        static void Main()
        {
            // asked you how old you are
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
        }
    }
}
