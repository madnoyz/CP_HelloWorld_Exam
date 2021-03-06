﻿//-----------------------------------------------------------------------
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
class HelloProgram : HelloConsole
    {
        /// <summary>
        ///     Main start to console application with command line arguments
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {

            IHelloConsole hello = new HelloConsole();
            hello.Run(args);

        }


    }
}
