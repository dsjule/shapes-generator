/*
 * I, David Jule, 00079459 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 * 
 * Author: David Jule. 
 * Date Created: October 5th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *      Class for the Sphere Shape. This is a subclass of the class Circle.cs
 *      -Create an Object of class Sphere and save its dimensions.
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
    class Sphere : Circle
    {
        /// <summary>
        /// Constructor for Object of Type Sphere.
        /// Assing its Type to Sphere upon creation.
        /// </summary>
        public Sphere() : base()
        {
            Type = "Sphere";
        }

        /// <summary>
        /// Get the surface area of this Sphere.
        /// Formula used to calculate this area is A = 4πr^2.
        /// </summary>
        /// <returns>double signed number representing the Area.</returns>
        public override double CalculateArea()
        {
            return base.CalculateArea() * 4;
        }

        /// <summary>
        /// Calculate the volume of this Sphere.
        /// Formula used to calculate the volume is V = 4/3πr^3.
        /// </summary>
        /// <returns>double signed number representing the volume.</returns>
        public override double CalculateVolume()
        {
            return (((4*(PI * Math.Pow(radius, 3)))/3));
        }


        /// <summary>
        /// ToString method to print all the information of this Shape.
        /// </summary>
        /// <returns>string message containing the data of this object.</returns>
        public override string ToString() => base.ToString() + $" [Volume = {Math.Round(CalculateVolume(),2)}]";
    }
}
