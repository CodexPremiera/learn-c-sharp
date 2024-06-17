// See https://aka.ms/new-console-template for more information

using System;

namespace Learn_C_Sharp.Lesson01_HelloWorld
{
    class HelloWorld
    {
        static void HelloMain()
        {
            // Hello World
            Console.WriteLine("Hello C#!");
            
            // Reading console
            Console.Write("How old are you? ");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old");
        }
    }
}