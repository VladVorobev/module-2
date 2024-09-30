using System;

public class Circle : Shape, IDrawable
{
    private double radius;

    public Circle(double radius) => this.radius = radius;

    public override double Area() => Math.PI * radius * radius;
    public override double Perimeter() => 2 * Math.PI * radius;

    public void Draw() => Console.WriteLine("Рисуем круг.");
}
