//Write a C# program that asks user to enter new number until user says "NO" when user says "yes" take input from user store the given input array calc sum of odd and dislay sum

using System;

class Program
{
    static void Main()
    {
        int sumOfOddNumbers = 0;
        string userInput = "yes"; // Initialize to a default value to avoid the "unassigned local variable" error

        while (userInput.ToLower() == "yes")
        {
            Console.Write("Enter a number: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 != 0)
                {
                    sumOfOddNumbers += number;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter 'yes' to continue or 'no' to stop: ");
            userInput = Console.ReadLine().ToLower();
        }

        Console.WriteLine($"The sum is {sumOfOddNumbers}");
        Console.ReadKey();
    }
}
