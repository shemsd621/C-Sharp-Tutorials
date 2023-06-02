// Write a program in C# Sharp to create a blank file on the disk.

class CreateFile 
{
    public static void Main() 
    {
        string fileName = @"myTest.txt";

        try
        {
            Console.Write("\nCreate a file named myTest.txt in the disk :\n");
            Console.Write("----------------------------------------------\n");

            using (FileStream fs = File.Create(fileName)) 
            {
                Console.WriteLine("File myTest.txt successfully created!");
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
