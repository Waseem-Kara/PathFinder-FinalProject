using System.Diagnostics;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Assert = NUnit.Framework.Assert;
using PathFinder.Controllers;
using PathFinder.Models;


namespace PathFinderTest
{
    [TestClass]
    public class PathFinderUnitTest
    {
        private readonly HomeController _homeController = new HomeController();
        private readonly AccountController _accountController = new AccountController();
        private readonly ProductController _productController = new ProductController();


        [TestMethod]
        public void HomeViewTest()
        {
            //Act
            var actual = _homeController.Index();
            
            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }

        [TestMethod]
        public void ContactViewTest()
        {
            //Act
            var actual = _homeController.Contact();

            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }

        [TestMethod]
        public void KeyboardViewTest()
        {
            //Act
            var actual = _productController.Index();

            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }

        [TestMethod]
        public void SoftwareViewTest()
        {
            //Act
            var actual = _productController.Software();

            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }

        [TestMethod]
        public void AccessoriesViewTest()
        {
            //Act
            var actual = _productController.Accessories();

            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }

        [TestMethod]
        public void ProductDescriptionViewTest()
        {
            //Act
            var actual = _productController.ProductDescription();

            //Assert
            Assert.IsInstanceOf<ActionResult>(actual);
        }

        [TestMethod]
        public void SignInIsValidTest()
        {
            //Arrange
            var loginModel = new Login {Email = "was_k@hotmail.co.uk", Password = "password"};

            //Act
            var result = _accountController.Login(loginModel) as ViewResult;

            //Assert
            Assert.That(result.ViewName, Is.EqualTo("_Login"));
            Assert.True(_accountController.ModelState.IsValid);
        }
    }
}
