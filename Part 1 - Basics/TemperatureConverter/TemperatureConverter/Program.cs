// See https://aka.ms/new-console-template for more information
// This program converts the temperature from Celsius to Kelvin and Fahrenheit
using System;

namespace TemperatureConverter;

public class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the temperature (Celsius) : ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Temperature in Kelvin : " + (celsius + 273) + " K");
        // F = (9C + (32 * 5)) / 5
        Console.WriteLine("Temperature in Fahrenheit : " + ((celsius * 9 + (32 * 5))/5) + " F");
    }
}
