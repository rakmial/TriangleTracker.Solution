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
    [TestMethod]
    public void ValidTriangle_AnyOneSideNotGreaterThanOtherTwoSum_True()
    {
      Assert.AreEqual(true, testTriangle.ValidTriangle);
    }
    [TestMethod]
    public void ValidTriangle_AnyOneSideNotGreaterThanOtherTwoSum_False()
    {
      Triangle naughtyTriangle = new Triangle(1,2,218);
      Assert.AreEqual(false, naughtyTriangle.ValidTriangle);
    }
    //[TestMethod]
    //public void MethodTested_Behavior_ExpectedResult()
    //{
    //  // Test Assert.AreEqual(ExpectedResult, method to elicit ExpectedResult)
    //}
  }
}