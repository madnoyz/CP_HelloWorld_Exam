//-----------------------------------------------------------------------
// <copyright file="HelloControllerTest.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using System;
using HelloWorldProgram.HelloWorldApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldProgram.HelloWorldApi.Tests.UnitTests
{


    /// <summary>
    ///     HelloControllerTest class that runs a test on the api hellocontroller
    /// </summary>
    [TestClass]
    public class HelloControllerTest
    {
        /// <summary>
        ///     Tests the HelloWorldApi HelloController GetValue method.
        /// </summary>
        [TestMethod]
        public void Go()
        {
            // Arrange
            HelloController controller = new HelloController();

            // Act
            String result = controller.GetValue();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
        }
    }
}
