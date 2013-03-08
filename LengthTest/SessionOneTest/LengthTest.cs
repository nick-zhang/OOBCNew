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
    }
}
