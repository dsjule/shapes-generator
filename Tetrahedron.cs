/*
 * 
 * Author: David Jule. 
 * Date Created: October 5th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *      Class for the Tetrahedron Shape. This is a subclass of the class Triangle.cs
 *      -Create an Object of class Tetrahedron and save its dimensions.
 *      -Prompt the user to input the dimensions manually.
 *      -Calculate the area
 *      -Calculate Volume
 *      -Print out values in a formatted string message.
 *       
 * Notes:
 *      
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Tetrahedron : Triangle
    {
        public Tetrahedron() : base()
        {
            Type = "Tetrahedron";
        }

        /// <summary>
        /// Calculate the surface area of this Tetrahedron.
        /// Formula used to calculare area is A = √3a^2.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return (Math.Sqrt(3) * (Math.Pow(base.CalculateArea(), 2)));
        }

        /// <summary>
        /// Calculate the surface area of this Tetrahedron.
        /// Formula used to calculate Volume is .
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return ((Math.Pow(base.CalculateArea(), 3)) / (6 * Math.Sqrt(2)));
        }

        /// <summary>
        /// ToString method to print all the information of this Shape.
        /// </summary>
        /// <returns>string message containing the data of this object.</returns>
        public override string ToString() => base.ToString() + $" [Volume = {Math.Round(CalculateVolume(), 2)}]";
    }
}
