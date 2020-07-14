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
  }
}
    /* 
      JavaScript code below:

      export function Triangle(side1, side2, side3){
      this.side1 = side1;
      this.side2 = side2;
      this.side3 = side3;
      this.traingleType = "";
      }

      Triangle.prototype.findTriangle = function(side1, side2, side3){
      if(side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1){
        this.traingleType = "not a triangle";
      }
      else if(side1 === side2 && side1 === side3){
        this.traingleType = "Equilateral";
      }
      else if(side1 === side2 || side1 === side3 || side2 === side3){
        this.traingleType = "Isosceles";
      }
      else if(side1 !== side2 && side1 !== side3 && side2 !== side3){
        this.traingleType = "Scalene";
      }
    */
