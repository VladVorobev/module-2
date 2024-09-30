using System;

public class Rectangle : Shape, IDrawable
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area() => width * height;
    public override double Perimeter() => 2 * (width + height);

    public void Draw() => Console.WriteLine("Рисуем прямоугольник.");
}
