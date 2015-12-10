using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Controllers;
using System.Web.Mvc;
using System.Web.Http.Results;

namespace Brello.Tests.Controllers
{
    [TestClass]
    public class BoardAPIControllerTest
    {
        [TestMethod]
        public void BoatdAPIEnsureICanCallgetMetod()
        {
            //Begin Arrange
            BoardApiController my_controller = new BoardApiController();
            string expected_output = "Hell is it me?";

            //End Arrange

            //Begin Act
          string actual_output = my_controller.Get();
            //End Act

            //Begin Assert
            Assert.AreEqual(expected_output, actual_output);
            //End Assert    


        }
    }
}
