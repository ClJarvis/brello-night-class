using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Brello.Tests.Models
{
    [TestClass]
    public class BrelloListTest
    {
        [TestMethod]
        public void BrelloListEnsureICanCreateInstance()
        {
            BrelloList brello_list = new BrelloList();
            Assert.IsNotNull(brello_list);
        }
    }
}
