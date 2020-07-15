using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Is it a triangle? Enter side 1: ");
      int side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 2: ");
      int side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter side 3: ");
      int side3 = int.Parse(Console.ReadLine());

      Triangle myTriangle = new Triangle(side1, side2, side3);
      {
      if(myTriangle.IsNotTriangle(side1, side2, side3))
      {
        Console.WriteLine("It's not a Triangle!");
      }
      else if(myTriangle.IsEqualateral(side1, side2, side3))
      {
        Console.WriteLine("It's an Equalateral Triangle!");
      }
      else if(myTriangle.IsIsosceles(side1, side2, side3))
      {
        Console.WriteLine("It's an Isosceles Triangle!");
      }
      else if(myTriangle.IsScalene(side1, side2, side3))
      {
        Console.WriteLine("It's a Scalene Triangle!");
      }
      else
      {
        Console.WriteLine("Something went wrong!");
      }
      }

    }
  }
}