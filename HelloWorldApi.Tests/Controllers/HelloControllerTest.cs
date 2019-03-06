using System;
using HelloWorldApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldProgram.HelloWorldApi.Tests.Controllers
{
    [TestClass]
    public class HelloControllerTest
    {
        [TestMethod]
        public void Value()
        {
            // Arrange
            HelloController controller = new HelloController();

            // 
            String result = controller.Value();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
        }
    }
}
