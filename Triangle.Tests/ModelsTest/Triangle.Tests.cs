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
      Assert.AreEqual("equi", newTriangle.SideCheck(5, 5, 5));
    }
    [TestMethod]
    public void SideCheck_IsIsosceles_True()
    {
      TriangleClass newTriangle = new TriangleClass();
      Assert.AreEqual("iso", newTriangle.SideCheck(2, 2, 3));
    }
    [TestMethod]
    public void SideCheck_IsScalene_True()
    {
      TriangleClass newTriangle = new TriangleClass();
      Assert.AreEqual("scal", newTriangle.SideCheck(2, 3, 4));
    }
    [TestMethod]
    public void SideCheck_IsNotTri_True()
    {
      TriangleClass newTriangle = new TriangleClass();
      Assert.AreEqual("not tri", newTriangle.SideCheck(4, 3, 10));
    }
  }
}