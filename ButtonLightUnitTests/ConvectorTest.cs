using System;
using ButtonLight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ButtonLightUnitTests
{
    [TestClass]
    public class ConvectorTest
    {
        [TestMethod]
        public void ConvectorCreeEstEteint()
        {
            Convector convector1 = new Convector();
            Assert.IsFalse(convector1.IsOn);
            //string expected = "Eteint";
            //string actual = convector1.ToString();
            //Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ConvectorAllumerLampeEstAllumee()
        {
            Convector convector1 = new Convector();
            convector1.TurnOn();
            Assert.IsTrue(convector1.IsOn);
            //string expected = "Allumé";
            //string actual = convector1.ToString();
            //Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ConvectorAllumeeEteindreEstEteinte()
        {
            Convector convector1 = new Convector();
            convector1.TurnOn();
            convector1.TurnOff();
            Assert.IsFalse(convector1.IsOn);
        }
        [TestMethod]
        public void ConvectorReAllumerEstAllumee()
        {
            Convector convector1 = new Convector();
            convector1.TurnOn();
            convector1.TurnOff();
            convector1.TurnOn();
            Assert.IsTrue(convector1.IsOn);
        }
    }
}
