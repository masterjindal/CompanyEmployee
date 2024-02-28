using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CompanyEmployee;
using CompanyEmployee.Controllers;


namespace CompanyEmployeeTestProject
{
    using NUnit.Framework;

    [TestFixture]
    public class HomeControllerTest
    {
        private HomeController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new HomeController();
        }
        [TearDown]
        public void Clear()
        {

        }

        [Test]
        public void Index()
        {
            //Arrange
            

            //Act
            ViewResult? result = _controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About()
        {           
            //Act
            ViewResult result = _controller.About() as ViewResult;

            //Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [Test]
        public void Contact()
        {
            //Act
            ViewResult result = _controller.Contact() as ViewResult;

            //Assert
            Assert.AreEqual("Your contact page.", result.ViewBag.Message);
        }
    }
}