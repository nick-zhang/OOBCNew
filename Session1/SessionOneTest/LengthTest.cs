﻿using System;
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
      
        [TestMethod]
        public void Given12InchesAdd2FeetShouldEqal3Feet()
        {
            var twelveInches = new Quantity(12, LengthUnit.INCH);
            var oneFeet = new Quantity(2, LengthUnit.FEET);
            var threeFeet = new Quantity(3, LengthUnit.FEET);
            Assert.AreEqual(threeFeet, twelveInches.Add(oneFeet));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Should not add two quantities with different units")]
        public void ShouldThrowExceptionWhenAddWithDifferentUnits()
        {
            var twelveInches = new Quantity(12, LengthUnit.INCH);
            var twoTBSP = new Quantity(2, VolumeUnit.TBSP);
            twelveInches.Add(twoTBSP);
        }
    }
}
