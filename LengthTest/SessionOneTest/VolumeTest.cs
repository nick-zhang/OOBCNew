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
        
        [TestMethod]
        public void Given1OZShouldEqual2TBSP()
        {
            Assert.AreEqual(new Quantity(1, VolumeUnit.OZ), new Quantity(2, VolumeUnit.TBSP));
        }
    }
}
