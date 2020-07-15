namespace TriangleTracker.Models
{
  public class Triangle
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public Triangle(int sideOneParam, int sideTwoParam, int sideThreeParam)
    {
      SideOne = sideOneParam;
      SideTwo = sideTwoParam;
      SideThree = sideThreeParam;
    }

    public string TriangleValidator()
    {
      if (SideOne + SideTwo <= SideThree || SideOne + SideThree <= SideTwo || SideTwo + SideThree <= SideOne)
      {
        return "This is not a triangle!";
      }
      else if (SideOne == SideTwo && SideOne == SideThree)
      {
        return "This Triangle is Equilateral";
      }
      else if (SideOne == SideTwo || SideOne == SideThree || SideTwo == SideThree)
      {
        return "This Triangle is Isosceles";
      }
      else if (SideOne != SideTwo && SideOne != SideThree && SideTwo != SideThree)
      {
        return "This Triangle is Scalene";
      }
      else
      {
        return "You have broken the laws of geometry";
      }
    }
  }
}
