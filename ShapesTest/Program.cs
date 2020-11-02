using System;

namespace ShapesTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please enter first value: ");
      double firstValue = double.Parse(Console.ReadLine());
      Console.Write("Please enter second value: ");
      double secondValue = double.Parse(Console.ReadLine());
      Console.Write("Please enter a name for your shapes: ");
      string thirdValue = Console.ReadLine();

      Triangle triangle = new Triangle(firstValue, secondValue, thirdValue);
      Square square = new Square(firstValue, secondValue, thirdValue);
      Cube cube = new Cube(firstValue, secondValue, thirdValue);
      Rectangle rectangle = new Rectangle(firstValue, secondValue, thirdValue);

      Console.WriteLine($"The area of triangle {thirdValue} is {triangle.GetArea()}\nThe area of square {thirdValue} is {square.GetArea()}\nThe area of cube {thirdValue} is {cube.GetArea()}\nThe area of {thirdValue} is {rectangle.GetArea()}");
    }
  }
}
