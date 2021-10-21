/*
 * 
 * Author: David Jule. 
 * Date Created: October 5th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *      Class for the Cube Shape. This is a subclass of the class Box.cs
 *      -Create an Object of class Cube and save its dimensions.
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
    class Cube : Box
    {
        /// <summary>
        /// Constructor for Obect of Type Cube.
        /// Assign its type to Cube upon creation.
        /// </summary>
        public Cube() : base()
        {
            Type = "Cube";
        }

        /// <summary>
        /// Calculate surface area of this Cube.
        /// Formula used is A = 6a^2.
        /// </summary>
        /// <returns>double signed number representing surface area.</returns>
        public override double CalculateArea()
        {
            return (6*(Math.Pow(base.widthOfShape,2)));
        }

        /// <summary>
        /// Calculate the volume of this Cube.
        /// Formula used is V = a^3.
        /// </summary>
        /// <returns>double signed number representing volume of the cube.</returns>
        public override double CalculateVolume()
        {
            return Math.Pow(widthOfShape,3);
        }
    }
}
