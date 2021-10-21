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
 *      Class for the Shape Circle. This is a subclass of the Abstract class Shape.cs
 *      -Create an Object of class Circle and save its dimensions.
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
    class Circle : Shape
    {
        public double radius;

        /// <summary>
        /// Constructor for Object of Type Circle.
        /// Assing its Type to Circle upon creation.
        /// </summary>
        public Circle() : base()
        {
            Type = "Circle";
        }

        /// <summary>
        /// Calculate the are for this Circle.
        /// Formula used to calculate this area is A = πr^2.
        /// </summary>
        /// <returns>double signed number representing the Area</returns>
        public override double CalculateArea()
        {
            return (PI*(Math.Pow(radius,2)));
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompts the user for dimensions of this Circle.
        /// </summary>
        public override void SetData()
        {
            //take in the first input, which will be the length of this shape.
            Console.Write("Please enter the radius of this circle : ");
            string input1 = Console.ReadLine();
            if (input1 == "" || !double.TryParse(input1, out radius))
                throw new ArgumentException("Please use only numbers to define the dimensions!");
        }

        /// <summary>
        /// ToString method to print all the information of this Shape.
        /// </summary>
        /// <returns>string message containing the data of this object.</returns>
        public override string ToString() => $"{Type} - [Radius = {radius}] [Diameter = {radius*2}] [Area = {Math.Round(CalculateArea(),2)}]";
        
    }
}
