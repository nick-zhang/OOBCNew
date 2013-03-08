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
            Assert.AreEqual(new Quantity(12, LengthUnit.INCH), new Quantity(1, LengthUnit.FEET));
        }

        [TestMethod]
        public void Given3FeetShouldEqal1Yard()
        {
            Assert.AreEqual(new Quantity(3, LengthUnit.FEET), new Quantity(1, LengthUnit.YARD));
        }
        
        [TestMethod]
        public void Given1760YardShouldEqal1Mile()
        {
            Assert.AreEqual(new Quantity(1760, LengthUnit.YARD), new Quantity(1, LengthUnit.MILE));
        }
    }
}
