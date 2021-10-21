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
 *      Class for the Cylinder Shape. This is a subclass of the class Circle.cs
 *      -Create an Object of class Cylinder and save its dimensions.
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
    class Cylinder : Circle
    {
        public double height;
        public Cylinder() : base()
        {
            Type = "Cylinder";
        }

        /// <summary>
        /// Calculate the surface area for this Cylinder.
        /// Formula used for this area is S = 2πr^2 + 2πrh.
        /// </summary>
        /// <returns>double signed number representing the area.</returns>
        public override double CalculateArea()
        {
            return ((2 * base.CalculateArea()) + (2 * PI * radius * height));
        }

        /// <summary>
        /// Calculate the volum of this Cylinder.
        /// Formula uded for this volume is V = πr^2h or V = Bh.
        /// </summary>
        /// <returns>double signed number representing the volume.</returns>
        public override double CalculateVolume()
        {
            return base.CalculateArea() * height;
        }

        /// <summary>
        /// Prompts the user for dimensions of this Cylinder.
        /// </summary>
        public override void SetData()
        {
            //take in the first input, which will be the length of this shape.
            Console.Write("Please enter the radius of this cylinder : ");
            string input1 = Console.ReadLine();
            Console.Write("Please enter the height of this cylinder : ");
            string input2 = Console.ReadLine();
            if (input1 == "" || !double.TryParse(input1, out radius) || 
                input2 == "" || !double.TryParse(input2, out height))
                throw new ArgumentException("Please use only numbers to define the dimensions!");
        }



        /// <summary>
        /// ToString method to print all the information of this Shape.
        /// </summary>
        /// <returns>string message containing the data of this object.</returns>
        public override string ToString() => base.ToString() + $" [Volume = {Math.Round(CalculateVolume(),2)}] [Height = {height}]" ;
    }
}
