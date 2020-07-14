using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_ReceivingCorrectSideValues_3()
    {
      Triangle testTriangle = new Triangle(3,3,3);
      Assert.AreEqual(3, testTriangle.SideOne);
      Assert.AreEqual(3, testTriangle.SideTwo);
      Assert.AreEqual(3, testTriangle.SideThree);
    }

    [TestMethod]
    public void TriangleValidator_ReceivingCorrectTrianlgeType_NotATriangle()
    {
      Triangle testTriangle = new Triangle(1,2,5);
      Assert.AreEqual("This is not a triangle!", testTriangle.TriangleValidator());
    }

    [TestMethod]
    public void TriangleValidator_ReceivingCorrectTrianlgeType_EquilateralTriangle()
    {
      Triangle testTriangle = new Triangle(3,3,3);
      Assert.AreEqual("This Triangle is Equilateral", testTriangle.TriangleValidator());
    }

    [TestMethod]
    public void TriangleValidator_ReceivingCorrectTrianlgeType_IsoscelesTriangle()
    {
      Triangle testTriangle = new Triangle(5,5,3);
      Assert.AreEqual("This Triangle is Isosceles", testTriangle.TriangleValidator());
    }

  }
}

// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()