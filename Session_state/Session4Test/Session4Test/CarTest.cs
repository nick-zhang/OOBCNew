using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session4;

namespace Session4Test
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void ShouldDisplayFlameoutAtStart()
        {
            var car = new Car();
            var message = car.Display();
            Assert.AreEqual("Flameout", message);
        }
    }
}
