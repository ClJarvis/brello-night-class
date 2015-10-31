using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;
using Moq;

namespace Brello.Tests.Models
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void CarEnsureICanCreatInstance()
        {
            Car mycar = new Car();
            Assert.IsNotNull(mycar);
        }

        [TestMethod]
        public void CarEnsureMyCarCanHonk()
        {
            Car mycar = new Car();
            Assert.AreEqual("Honk!", mycar.Horn());
        }

        [TestMethod]
        public void CarEnsureICanMockMyCarHorn()
        {
            Mock<Car> mock_car = new Mock<Car>();
            mock_car.Setup(x => x.Horn()).Returns("BEEP!"); 
            Assert.AreEqual("BEEP!", mock_car.Object.Horn());
        }

        [TestMethod]
        public void CarEnsureICanMockInterface()
        {
            Mock<ICar> mock_car = new Mock<ICar>();
            //THis is invalid: Var myvar = newIcar();
            mock_car.Setup(x => x.Honk()).Returns("BEEP!");
            Assert.AreEqual("BEEP!", mock_car.Object.Honk());
            mock_car.Verify(x => x.Honk(), Times.Once);
        }

     /* 
     Moq requires methods to be called explicity after being set up
        
        [TestMethod]
        public void CarEnsureReadyEnginesIsCalled()
        {
            Mock<Car> mock_car = new Mock<Car>();
            mock_car.Object.Horn();
            mock_car.Setup(x => x.ReadyEngines());
          //  mock_car.Setup(x => x.Horn()).Returns("BEEP!");
           // Assert.AreEqual("BEEP!", mock_car.Object.Horn());
            mock_car.Verify(x => x.ReadyEngines(), Times.Once);
        } */
    }
}
