using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void InitInputsX_Get_X()
    {
      testTriangle = new Triangle(1,2,3);
      Assert.AreEqual(1, testTriangle.X);
    }
    [TestMethod]
    public void InitInputsY_Get_Y()
    {
      testTriangle = new Triangle(1,2,3);
      Assert.AreEqual(2, testTriangle.Y);
    }
    [TestMethod]
    public void InitInputsZ_Get_Z()
    {
      testTriangle = new Triangle(1,2,3);
      Assert.AreEqual(3, testTriangle.Z);
    }
    //[TestMethod]
    //public void MethodTested_Behavior_ExpectedResult()
    //{
    //  // Test Assert.AreEqual(ExpectedResult, method to elicit ExpectedResult)
    //}
    //[TestMethod]
    //public void MethodTested_Behavior_ExpectedResult()
    //{
    //  // Test Assert.AreEqual(ExpectedResult, method to elicit ExpectedResult)
    //}
  }
}