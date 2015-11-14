using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Controllers;
using System.Web.Mvc;
using Moq;
using Brello.Models;
using System.Collections.Generic;

namespace Brello.Tests.Controllers
{
    [TestClass]
    public class BoardContollerTest
    {

        private Mock<BoardContext> mock_context;
        private Mock<BoardRepository> mock_repository;
        private ApplicationUser owner, user1, user2;

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<BoardContext>();
            mock_repository = new Mock<BoardRepository>(MockBehavior.Default, new object[] { mock_context});
            owner = new ApplicationUser();
            user1 = new ApplicationUser();
            user2 = new ApplicationUser();
        }

        [TestCleanup]
        public void Cleanup()
        {
            mock_context = null;
        }

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

        [TestMethod]
        public void BoardControllerEnsureListOfUserBoards()
        {
            System.Collections.Generic.List<Board> my_boards = new List<Board>
            {
                new Board {Title = "My Awsoem Board", BoardId = 1, Owner = owner },
                new Board {Title = "My Grogery Board", BoardId = 2, Owner = owner }
            };
             BoardController controller = new BoardController(mock_repository.Object);
            mock_repository.Setup(r => r.GetAllBoards()).Returns(my_boards);
            //End Arrange

            //Begin Act
            ViewResult result = controller.Index() as ViewResult;
            //End Act

            //Begin Assert
            CollectionAssert.AreEqual(my_boards, result.ViewBag.Boards);
            //End Assert
        }
    }
}
