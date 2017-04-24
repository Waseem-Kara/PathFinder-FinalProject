using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFinder.Controllers;
using NUnit.Framework;
using System.Web.Mvc;

namespace PathFinderTest
{
    [TestClass]
    public class PathFinderUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            AccountController acController = new AccountController();

            //Act
            var actual = acController.Login();

            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }
    }
}
    