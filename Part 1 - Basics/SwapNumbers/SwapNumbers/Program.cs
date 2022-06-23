// See https://aka.ms/new-console-template for more information
using System;

namespace SwapNumbers 
{
    public class SwapNumber 
    {
        public static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Please input the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Swapping the numbers...");

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("First number is : " + num1);
            Console.WriteLine("Second number is : " + num2);
            Console.WriteLine("Numbers swapped successfully!");
        }
    }
}
