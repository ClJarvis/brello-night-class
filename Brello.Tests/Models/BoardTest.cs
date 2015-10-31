using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Brello.Tests.Models
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void BoardEnsureICanCreateInstance()
        {
            Board board  = new Board();
            Assert.IsNotNull(board);
        }

        [TestMethod]
        public void BoardPropertiesWork()
        {
            //Color color = new Color { Name = "Blue", Value = "#0000ff" };
            // Object Initializer syntax
            Board board = new Board ();
            // Otherwise you'd have to
            Assert.AreEqual("My Board", board.Title);
            Assert.AreEqual(0, board.Lists.Count);
            Assert.AreEqual(0, board.Followers.Count);
          
        }
    }
}
