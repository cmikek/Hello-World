using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.WebAPI;
using HelloWorld.WebAPI.Controllers;
using HelloWorld.Interfaces;

namespace HelloWorld.WebAPI.Tests.Controllers
{
    [TestClass]
    public class MessageControllerTest
    {
        [TestMethod]
        public void Get()
        {
            MessageController controller = new MessageController();

            IMessage message = controller.Get();

            Assert.IsNotNull(message);
            Assert.AreEqual("Hello World", message.Text);
        }
    }
}
