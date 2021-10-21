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
 *      Class for the Square Shape. This is a subclass of the class Rectangle.cs
 *      -Create an Object of class Square and save its dimensions.
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
    class Square : Rectangle
    {
        /// <summary>
        /// Constructor for Object of type Square.
        /// Assign its Type to Square upon creation.
        /// </summary>
        public Square() : base()
        {
            Type = "Square";
        }

        /// <summary>
        /// Prompts the user for dimensions of this Square.
        /// </summary>
        public override void SetData()
        {
            //take in the first input, which will be the length of this shape.
            Console.Write("Please enter the base for this shape: ");
            string input1 = Console.ReadLine();
            Console.Write("Please enter the height for this shape: ");
            string input2 = Console.ReadLine();
            if (input1 == "" || input2 == "" || !double.TryParse(input1, out widthOfShape) || !double.TryParse(input2, out heightOfShape))
                throw new ArgumentException("Please use only numbers to define the dimensions!");
            if (input1 != input2)
                throw new ArgumentException("A Square needs to have the same dimentions");
        }


    }
}
