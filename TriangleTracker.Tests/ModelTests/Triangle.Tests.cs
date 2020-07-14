using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName;

namespace TriangleTrackerProject.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void HasOneSide_ReceivingALengthValue_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle);
    }
  }
}