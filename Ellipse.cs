/*
 * I, David Jule, 00079459 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 * 
 * Author: David Jule. 
 * Date Created: October 7th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *      Class for the Shape Ellipse. This is a subclass of the class Rectangle.cs
 *      -Create an Object of class Ellipse and save its dimensions.
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
    class Ellipse : Rectangle
    {
        /// <summary>
        /// Constructor for Object of type Ellipse.
        /// Assign its Type to Ellipse upon creation.
        /// </summary>
        public Ellipse() : base()
        {
            Type = "Ellipse";
        }

        /// <summary>
        /// Calculate the area for this Ellipse.
        /// Formula used for this shape is A = PI * width * height.
        /// </summary>
        /// <returns>double signed number representing Area.</returns>
        public override double CalculateArea()
        {
            return (widthOfShape * heightOfShape * PI);
        }
    }
}
