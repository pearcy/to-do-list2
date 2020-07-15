using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsEqualateral_EqualSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEqualateral(2,2,2));
    }
    [TestMethod]
    public void IsIsosceles_TwoSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsIsosceles(2,2,3));
    }
    [TestMethod]
    public void IsScalene_DiffSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsScalene(2,3,4));
    }

    [TestMethod]
    public void IsNotTriangle_SidesNotAdding_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsNotTriangle(2,3,12));
    }
  }
}