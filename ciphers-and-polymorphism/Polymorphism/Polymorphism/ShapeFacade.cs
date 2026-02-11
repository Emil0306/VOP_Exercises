using System;

namespace Polymorphism.Polymorphism;

public sealed class ShapeFacade
{
    // Creating the Singleton
    private static readonly Lazy<ShapeFacade> Lazy = new(() => new ShapeFacade());
    
    public static ShapeFacade GetInstance => Lazy.Value;

    private ShapeFacade()
    {
    }
    
    public enum Shapes
    {
        Ellipse,
        Rectangle,
        Circle,
        Square
    };

    public string GetShapeInfo(Shapes shape, params double[] p)
    {
        AbstractShape abstractShape;
        switch (shape)
        {
            case Shapes.Ellipse:
                abstractShape = new Ellipse(p[0], p[1]);
                break;
            case Shapes.Circle:
                abstractShape = new Circle(p[0]);
                break;
            case Shapes.Square:
                abstractShape = new Square(p[0]);
                break;
            case Shapes.Rectangle:
                abstractShape = new Rectangle(p[0], p[1]);
                break;
            default:
                throw new Exception("Unknown shape type");
        }
        return abstractShape.ToString();
    }
}