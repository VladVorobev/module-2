using System;

public class Triangle : Shape, IDrawable
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double Area() => 0.5 * baseLength * height;
    public override double Perimeter() => baseLength + height + Math.Sqrt(baseLength * baseLength + height * height);

    public void Draw() => Console.WriteLine("Рисуем треугольник.");
}
