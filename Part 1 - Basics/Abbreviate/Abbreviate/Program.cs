// program to abbreviate any phrase or sentence

using System;

namespace Abbreviate;

public class Program
{
    public static string Abbreviation(string input)
    {
        int i = 0;
        string abr = "";
        // splitting the sentence and storing the words in an array
        string[] list = input.Split(' ');

        // iterating through the list
        for (i = 0; i < list.Length; i++)
        {
            // turn to upper case
            string word = list[i].ToUpper();
            abr +=  word[0] + ".";
        }
        // return the abbreviated string
        return abr;
    }

    public static void Main(string[] args)
    {
        Console.Write("What do you need to abbreviate? ");
        string sentence = Console.ReadLine();
        // checks whether the input is empty
        if (sentence.Equals(""))
        {
            Console.WriteLine("Invalid input");
        } else 
        {
            // calls the Abbreviation method
            string ab = Abbreviation(sentence);
            Console.WriteLine("Abbreviation : " + ab);
        }
    }
}
