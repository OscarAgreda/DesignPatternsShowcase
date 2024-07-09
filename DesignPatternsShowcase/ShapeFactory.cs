namespace DesignPatternsShowcase;

public class ShapeFactory
{
    public IShape CreateShape(string shapeType)
    {
        switch (shapeType)
        {
            case "Circle":
                return new Circle();
            case "Square":
                return new Square();
            default:
                throw new ArgumentException("Invalid shape type");
        }
    }
}