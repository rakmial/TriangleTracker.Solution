using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    Triangle testTriangle = new Triangle(1,2,3);
    [TestMethod]
    public void InitInputsX_Get_X()
    {
      Assert.AreEqual(1, testTriangle.X);
    }
    [TestMethod]
    public void InitInputsY_Get_Y()
    {
      Assert.AreEqual(2, testTriangle.Y);
    }
    [TestMethod]
    public void InitInputsZ_Get_Z()
    {
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