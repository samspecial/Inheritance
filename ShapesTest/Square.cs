namespace ShapesTest
{
  public class Square : Figure
  {
    public string SquareShape { get; }

    public Square(double x, double y, string squareShape) : base(x, y)
    {
      SquareShape = squareShape;
    }

    public override double GetArea()
    {
      return X * X;
    }
  }
}