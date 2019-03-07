//-----------------------------------------------------------------------
// <copyright file="HelloController.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldProgram.HelloWorldApi.Controllers
{
    /// <summary>
    ///     HelloController class provides GET, POST, PUT, DELETE web api and inherits from ApiController
    /// </summary>
    public class HelloController : ApiController
    {
        // GET: api/hello
        [HttpGet]
        public string GetValue()
        {
            return "Hello World";
        }

        // POST: api/hello
        [HttpPost]
        public void SaveNewValue([FromBody]string value)
        {
  
        }

        // PUT: api/hello/1
        [HttpPut]
        public void UpdateValue(int id, [FromBody]string value)
        {

        }

        // DELETE: api/hello/1
        [HttpDelete]
        public void RemoveValue(int id)
        {

        }


    }
}
