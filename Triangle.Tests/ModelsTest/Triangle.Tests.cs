using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void SideCheck_IsEquilateral_True()
    {
      TriangleClass newTriangle = new TriangleClass();
      Assert.AreEqual(true, newTriangle.SideCheck(5, 5, 5));
    }

  }
}