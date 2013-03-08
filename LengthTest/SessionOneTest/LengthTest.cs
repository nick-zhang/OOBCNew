using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionOne;

namespace SessionOneTest
{
    [TestClass]
    public class LengthTest
    {
        [TestMethod]
        public void Given12InchesShouldEqual1Feet()
        {
            Assert.AreEqual(new Quantity(12, Unit.INCH), new Quantity(1, Unit.FEET));
        }

        [TestMethod]
        public void Given3FeetShouldEqal1Yard()
        {
            Assert.AreEqual(new Quantity(3, Unit.FEET), new Quantity(1, Unit.YARD));
        }
    }
}
