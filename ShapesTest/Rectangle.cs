namespace ShapesTest
{
  public class Rectangle : Figure
  {
    public string RectangleShape { get; }

    public Rectangle(double x, double y, string rectangleShape) : base(x, y)
    {
      RectangleShape = rectangleShape;
    }

    public override double GetArea()
    {
      return X * Y;
    }

  }
}