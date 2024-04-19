using System;

public class StringName
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        for (int i = 0; i < inputString.Length; i++)
        {
            Console.WriteLine(inputString[i]);
        }
        Console.ReadKey(); // This line waits for a key press before exiting, which prevents the console window from closing immediately.
    }
}