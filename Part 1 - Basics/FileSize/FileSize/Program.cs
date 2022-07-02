using System;

namespace FileSize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileInfo file = new FileInfo("textFile.txt");
            Console.WriteLine("Size of a file : " + file.Length);
        }
    }
}
