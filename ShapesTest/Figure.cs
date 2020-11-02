namespace ShapesTest
{
  public class Figure
  {
    public double X { get; }
    public double Y { get; }
    // public string ShapeName{get;}
    public Figure(double x, double y)
    {
      X = x;
      Y = y;

    }

    public virtual double GetArea()
    {
      return X * Y;
    }

  }

}