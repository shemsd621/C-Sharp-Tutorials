// See https://aka.ms/new-console-template for more information
// This program lowers the case of any sentence given to it

using System;

namespace LowerTheCase 
{
    public class Project 
    {
        public static void Main(string[] args)
        {
            Console.Write("Write your sentence in capitals : ");
            string input = Console.ReadLine();
            Console.WriteLine(input.ToLower());
        }
    }
}
