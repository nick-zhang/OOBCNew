using LengthTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LengthTest
{
    [TestClass]
    public class LengthCompareTest
    {
        [TestMethod]
        public void Given12InchesShouldEqual1Feet()
        {
            Assert.AreEqual(new Quantity(12, Unit.INCH), new Quantity(1, Unit.FEET));
        }
    }

    public enum Unit
    {
        INCH,
        FEET
    }

    public class Quantity
    {
        public Quantity(int value, Unit unit)
        {
            throw new System.NotImplementedException();
        }
    }
}