namespace ShapesTest
{
  public class Triangle : Figure
  {
    public string TriangleShape { get; }
    public Triangle(double x, double y, string triangleShape) : base(x, y)
    {
      TriangleShape = triangleShape;
    }

    public override double GetArea()
    {
      return 0.5 * X * Y;
    }
  }
}