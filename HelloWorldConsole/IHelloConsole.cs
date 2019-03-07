//-----------------------------------------------------------------------
// <copyright file="IHelloConsole.cs" company="Clyde Pabro">
//  Copyright (c) 2019 All Rights Reserved
//  <author>Clyde Pabro</author>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProgram.HelloWorldConsole
{
    /// <summary>
    ///     Interface to run Hello World Program
    /// </summary>
    public interface IHelloConsole
    {
        /// <summary>
        ///     Run the Hello World program from different implementations
        /// </summary>
        /// <param name="args">Command line arguments</param>
        void Run(string[] arguments);
    }
}
