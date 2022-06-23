// See https://aka.ms/new-console-template for more information
// program to multiply 3 numbers entered by the user

using System;

namespace SimpleMultiplication 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int num1, num2, num3;

            Console.WriteLine("Please input your first number : ");
            // ReadLine reads the next line of characters
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input your second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input your third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;

            Console.WriteLine("Result of " + num1 + " x " + num2 + " x " + num3 + " = " + result);
            // Console.WriteLine("Result of {0} x {1} x {2} = {3}", num1, num2, num3, result);
        }
    }
}
