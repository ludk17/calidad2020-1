using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication.Pruebas.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void TestIndexReturnView()
        {            
            var controller = new HomeController();
            var view = controller.Index() as ViewResult;
            Assert.IsInstanceOf<ViewResult>(view);
            Assert.IsInstanceOf<List<User>>(view.Model);
        }

        [Test]
        public void TestAboutReturnView()
        {
            var controller = new HomeController();
            var view = controller.About() as ViewResult;

            Assert.IsNotNull(view.ViewBag.Message);
            Assert.AreEqual("Mi Valor", view.ViewBag.Valor);
            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}
