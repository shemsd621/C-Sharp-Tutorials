// See https://aka.ms/new-console-template for more information
// This program gets a list of words and reverses it
using System;

namespace ReverseString;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string that should be reversed : ");
        string phrase = Console.ReadLine();

        List<string> list = new List<string>();
        string[] words = phrase.Split(' ');
        string result = "";

        for (int i = words.Length - 1; i>=0; i--) 
        {
            result += words[i] + " ";
        }

        list.Add(result);
        foreach(string word in list)
        {
            Console.WriteLine("Reversed string : " + word);
        }
    }
}
