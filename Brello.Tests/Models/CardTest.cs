using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;

namespace Brello.Tests.Models
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void TCardEnsureICanCreateInstance()
        {
            Card c = new Card();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void ColorEnsurePropertieswork()
        {
            Color color = new Color { Name = "Blue", Value = "0000ff" };
            //Object Initializer synax
            Card c = new Card { Title = "My Card", Description = "A description of my card", BorderColor = color };
           
            Assert.AreEqual("My Card", c.Title);
            Assert.AreEqual("A description of my card", c.Description);
            Assert.AreEqual("Blue", c.BorderColor.Name);
        }
    }
}
