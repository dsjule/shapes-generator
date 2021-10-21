/*
 * 
 * Author: David Jule. 
 * Date Created: October 7th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *      Class for the Shape Triangle. This is a subclass of the class Rectangle.cs
 *      -Create an Object of class Triangle and save its dimensions.
 *      -Prompt the user to input the dimensions manually.
 *      -Calculate the area
 *      -Print out values in a formatted string message.
 *       
 * Notes:
 *      -Base method of CalculateVolume() is not used as this is a 2D shape, not 3D.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Triangle : Rectangle
    {
        /// <summary>
        /// Constructor for Object of Type Triangle.
        /// Assign its Type to Triangle upon creation.
        /// </summary>
        public Triangle() : base()
        {
            Type = "Triangle";
        }

        /// <summary>
        /// Get the surface area of this Triangle.
        /// Formula used is A = 1/2bh.
        /// </summary>
        /// <returns>double signed number representing the area.</returns>
        public override double CalculateArea()
        {
            return base.CalculateArea()/2;
        }
    }
}
