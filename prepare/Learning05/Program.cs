using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square1 = new Square("Blue",4);
        Rectangle rectangle1 = new Rectangle("Red", 5,6);
        Circle circle1 = new Circle("Yellow", 9);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}

public class Shape
{
    protected string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return -1;
    }

    public Shape(string color)
    {
        _color = color;
    }

}

public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return (_side * _side);
    }

}

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return (_length * _width);
    }

}

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return ( System.Math.PI * _radius * _radius );
    }

}

