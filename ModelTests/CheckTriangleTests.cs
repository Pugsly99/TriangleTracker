using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests 
{
  [TestClass]
  public class CheckTriangleTests
  {
    [TestMethod]

    public void IsTriangle_IsEquilateral_True()
    {
      CheckTriangle testCheckTriangle = new CheckTriangle();
      Assert.AreEqual(true, testCheckTriangle.IsTriangle(4, 4, 4));
    }
  }
}