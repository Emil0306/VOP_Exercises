namespace Polymorphism.Polymorphism;

public class Square : Rectangle
{
    private double l;
    
    public Square(double length) : base(length, length)
    {
        l = length;
    }
}