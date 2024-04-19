//            LAB 3

//Write a c# program to create class calcultor with following specifications 
//- Properties: Principle,Time,Rate
//- Constructor: Parametrical constructor to initialize Principle and Time.Static constructor to initialize Rate
//- Method: "CalculateInterest" Method to calculate simple interest and "Display" Method for showing calcuated interest of a person
//Then,- Take Principle,Rate and Time as input from user for 10 persons.

using System;

class Calculator
{
    // Properties
    public double Principle { get; set; }
    public double Time { get; set; }
    public static double Rate { get; set; }

    // Parametric Constructor
    public Calculator(double principle, double time)
    {
        Principle = principle;
        Time = time;
    }

    // Static Constructor to initialize Rate
    static Calculator()
    {
        Rate = 0.05; 
    }

    // Method to calculate simple interest
    public double CalculateInterest()
    {
        return Principle * Rate * Time;
    }

    // Method to display calculated interest
    public void Display()
    {
        Console.WriteLine($"Simple Interest for Principle={Principle}, Rate={Rate}, Time={Time} is {CalculateInterest()}");
    }
}

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter Principle for Person {i}: ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter Time for Person {i}: ");
            double time = Convert.ToDouble(Console.ReadLine());

            Calculator personCalculator = new Calculator(principle, time);
            personCalculator.Display();

        }
        Console.ReadKey();
    }
}
