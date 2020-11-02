namespace ShapesTest
{
  public class Cube : Figure
  {
    public string CubeShape { get; }

    public Cube(double x, double y, string cubeShape) : base(x, y)
    {
      CubeShape = cubeShape;
    }

    public override double GetArea()
    {
      return X * 6;
    }

  }
}