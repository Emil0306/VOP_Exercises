namespace Polymorphism.Polymorphism;

public class Circle : Ellipse
{
    private double r;

    public Circle(double radius) : base(radius, radius)
    {
        r = radius;
    }
}