using System;

namespace Geometry
{
    public class Rectangle
    {
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}

namespace ProgramNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width;

            Console.WriteLine("Rectangle Area Calculator\n");

            Console.Write("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());

            double area = Geometry.Rectangle.CalculateArea(length, width);

            Console.WriteLine($"Area of the rectangle: {area}");

            Console.ReadLine();
        }
    }
}
