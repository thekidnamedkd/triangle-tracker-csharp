using System;
using System.Collections.Generic;
using TriangleTracker.Models;

namespace TriangleTracker {

  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Enter three side length to see what type of triangle it would make!");
      Console.WriteLine("Enter a length for side one:");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);
      Console.WriteLine("Enter a length for side two:");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);
      Console.WriteLine("Enter a length for side three:");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);

      Triangle inputtedTriangle = new Triangle(sideOne, sideTwo, sideThree);
      Console.WriteLine(inputtedTriangle.TriangleValidator());
    }
  }
}