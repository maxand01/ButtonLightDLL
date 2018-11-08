using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ButtonLight;


namespace TestUnitaires
{
    [TestClass]
    public class LightUnitTest
    {
        [TestMethod]
        public void LampeCreeEstEteinte()
        {
            Light1 light1 = new Light1();
            Assert.IsFalse(light1.IsOn); 
            string expected = "Eteint";
            string actual = light1.ToString();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void LampeAllumerLampeEstAllumee()
        {
            Light1 light1 = new Light1();
            light1.TurnOn();
            Assert.IsTrue(light1.IsOn);
            string expected = "Allumé";
            string actual = light1.ToString();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void LampeAllumeeEteindreEstEteinte()
        {
            Light1 light1 = new Light1();
            light1.TurnOn();
            light1.TurnOff();
            Assert.IsFalse(light1.IsOn);
        }
        [TestMethod]
        public void LampeReAllumerEstAllumee()
        {
            Light1 light1 = new Light1();
            light1.TurnOn();
            light1.TurnOff();
            light1.TurnOn();
            Assert.IsTrue(light1.IsOn);
        }
    }
}
