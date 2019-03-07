//-----------------------------------------------------------------------
// <copyright file="HelloConsole.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using HelloWorldProgram.HelloWorldConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProgram.HelloWorldConsole 
{
    /// <summary>
    ///     Run Hello World Program using interface for other implementations
    /// </summary>
    public class HelloConsole : IHelloConsole
    {
        /// <summary>
        ///     Run the Hello World program from different implementations
        /// </summary>
        /// <param name="args">Command line arguments</param>
        public void Run(string[] arguments)
        {
            // WebClient consumes api endpoint and writes output
            using (var client = new WebClient())
            {
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("http://localhost:6921/api/hello");
                Console.WriteLine(Environment.NewLine + result);
            }
            Console.ReadLine();
        }
    }
}
