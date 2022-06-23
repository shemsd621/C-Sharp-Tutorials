// See https://aka.ms/new-console-template for more information
// Simple program to display HelloWorld

using System;

// namespaces prevent naming conflicts 
namespace HelloWorld 
{
    class Program 
    {
        // Main method - First method called
        // takes an array of strings as input
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, World!");
            Console.Read(); // waits for a key press from the user before closing the window
        }
    }
}

