using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;

namespace Brello.Tests.Models
{
    [TestClass]
    public class ColorTests
    {
        [TestMethod]
        public void ColorEnsureICanCreateInstace()
        {
            Color c = new Color();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void ColorEnsureProppertieswork()
        {
            //Object Initializer synax
            Color c = new Color { Name = "Blue", Value = "0000ff" };
            //otherwise you'd have tp 
            /*
            Color c = new Color();
            c.Name = "Blue";
            c.Value = "0000ff";
            */
            Assert.AreEqual("Blue", c.Name);
            Assert.AreEqual("0000ff", c.Value);
        }

        [TestMethod]
        public void ColorEnsureColorsAreEqual()
        {
            Color color1 = new Color { Name = "Blue", Value = "#0000ff" };
            Color color2 = new Color { Name = "Blue", Value = "#0000ff" };
            Assert.AreEqual(0, color1.CompareTo(color2));
            Assert.IsTrue(color1 == color2);
        }
    }
}
