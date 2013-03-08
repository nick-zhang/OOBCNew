using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionOne;

namespace SessionOneTest
{
    [TestClass]
    public class VolumeTest
    {
        [TestMethod]
        public void Given1TBSPShouldEqual3TSP()
        {
            Assert.AreEqual(new Quantity(3, VolumeUnit.TSP), new Quantity(1, VolumeUnit.TBSP));
        }
    }
}
