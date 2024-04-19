using System;
class Shape
{
    protected double Length { get; set; }
    protected double Breadth { get; set; }

    public Shape(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public virtual double Area()
    {
        return 0; // Default implementation, to be overridden by derived classes
    }
}

class Rectangle : Shape
{
    public Rectangle(double length, double breadth) : base(length, breadth)
    {
    }

    public override double Area()
    {
        return Length * Breadth;
    }
}

class Square : Shape
{
    public Square(double side) : base(side, side)
    {
    }

    public override double Area()
    {
        return Length * Length;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) : base(radius, radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        double length, breadth, side, radius;

        Console.Write("Enter length for Rectangle: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Enter breadth for Rectangle: ");
        breadth = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(length, breadth);
        Console.WriteLine("Area of Rectangle: " + rectangle.Area());

        Console.Write("\nEnter side length for Square: ");
        side = double.Parse(Console.ReadLine());
        Square square = new Square(side);
        Console.WriteLine("Area of Square: " + square.Area());

        Console.Write("\nEnter radius for Circle: ");
        radius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine("Area of Circle: " + circle.Area());
    }
}