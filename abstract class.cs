using System;

abstract class Shape
{
    public abstract double Area();
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle(5, 10);
        Console.WriteLine("Area of rectangle: {0}", r.Area());
    }
}
