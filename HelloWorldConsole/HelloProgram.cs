//-----------------------------------------------------------------------
// <copyright file="HelloProgram.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProgram.HelloWorldConsole
{ 

/// <summary>
///     HelloProgram class that runs the console application
/// </summary>
class HelloProgram
    {
        /// <summary>
        ///     Main start to console application with command line arguments
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
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
