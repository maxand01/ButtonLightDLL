using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageButton;
using ButtonLight;
 
namespace TestUnitaires
{
    [TestClass]
    public class ButtonUnitTest
    {
        [TestMethod]
        public void BoutonCreeLampeEstEteinte()
        {
            Light1 light1 = new Light1();
            Button button1 = new Button(light1);
            Assert.IsFalse(light1.IsOn);
        }

        [TestMethod]
        public void BoutonPress1FoisLampeAllumee()
        {
            Light1 light1 = new Light1();
            Button button1 = new Button(light1);
            button1.Press();
            Assert.IsTrue(light1.IsOn);
        }

        [TestMethod]
        public void BoutonPress2FoisLampeEteinte()
        {
            Light1 light1 = new Light1();
            Button button1 = new Button(light1);
            button1.Press();
            button1.Press();
            Assert.IsFalse(light1.IsOn);
        }

        [TestMethod]
        public void BoutonPress3FoisLampeAllumee()
        {
            Light1 light1 = new Light1();
            Button button1 = new Button(light1);
            button1.Press();
            button1.Press();
            button1.Press();
            Assert.IsTrue(light1.IsOn);
        }

      
    }
}
