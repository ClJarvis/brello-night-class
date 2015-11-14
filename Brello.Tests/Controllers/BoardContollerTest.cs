using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Controllers;
using System.Web.Mvc;

namespace Brello.Tests.Controllers
{
    [TestClass]
    public class BoardContollerTest
    {
        [TestMethod]
        public void BoardControllerEnsureIndexPageExist()
        {
            //Begin Arrange
            BoardController controller = new BoardController();
            //End Arrange

            //Begin Act
           ViewResult result = controller.Index() as ViewResult;
            //End Act

            //Begin Assert
            Assert.IsNotNull(result);
            //End Assert
        }

        [TestMethod]
        public void EnsureIndexViewExist()
        {
            //Begin Arrange
            BoardController controller = new BoardController();
            //End Arrange

            //Begin Act
            ViewResult result = controller.Index() as ViewResult;
            //End Act

            //Begin Assert
            Assert.AreEqual( "Index", result.ViewName);
            //End Assert    
        }
        [TestMethod]
        public void BoardControllerEnsureItHasThings()
        {
            BoardController controller = new BoardController();
            //End Arrange

            //Begin Act
            ViewResult result = controller.Index() as ViewResult;
            //End Act

            //Begin Assert
            string expected_message = "My Boards";
            Assert.AreEqual(expected_message, result.ViewBag.Message);
            //End Assert
        }
    }
}
