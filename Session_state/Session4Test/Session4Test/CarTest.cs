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
            var car = new Car(string.Empty);
            var message = car.Display();
            Assert.AreEqual("Flameout", message);
        }
        
        [TestMethod]
        public void ShouldDisplayFlameoutGivenFlameoutThenStepOnTheGas()
        {
            var car = new Car("Flameout");
            car.StepOnGas();
            var message = car.Display();
            Assert.AreEqual("Flameout", message);
        }
        
        [TestMethod]
        public void ShouldDisplayFlameoutGivenFlameoutThenShiftGear()
        {
            var car = new Car("Flameout");
            car.ShifGear();
            var message = car.Display();
            Assert.AreEqual("Flameout", message);
        }
    }
}
