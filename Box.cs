/*
 * 
 * Author: David Jule.
 * Date Created: October 5th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *      Class for the Box Shape. This is a subclass of the class Rectangle.cs
 *      -Create an Object of class Box and save its dimensions.
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
    class Box : Rectangle
    {
        public double lengthOfShape;


        /// <summary>
        /// Constructor for Object of type Box.
        /// Assign its Type to Box upon creation.
        /// </summary>
        public Box() : base()
        {
            Type = "Box";
        }

        /// <summary>
        /// Calculate the surface area of this rectangular prism. 
        /// Formula used is A = 2 (wl + lh + hw)
        /// </summary>
        /// <returns>double signed number representing the surface area of the rectangular prism</returns>
        public override double CalculateArea()
        {
            return (2*((widthOfShape * lengthOfShape)+
                   (lengthOfShape*heightOfShape)+
                   (heightOfShape*widthOfShape)));
        }

        /// <summary>
        /// Calculate Volume of this Rectangular Prism.
        /// </summary>
        /// <returns>double signed number representing the volume of this shape.</returns>
        public override double CalculateVolume()
        {
            return widthOfShape * heightOfShape * heightOfShape;
        }

        /// <summary>
        /// Prompts the user for dimensions of this Rectangular Prism.
        /// </summary>
        public override void SetData()
        {
            //take in the first input, which will be the length of this shape.
            Console.Write("Please enter the base for this shape: ");
            string input1 = Console.ReadLine();
            Console.Write("Please enter the height for this shape: ");
            string input2 = Console.ReadLine();
            Console.Write("Please enter the length for this shape: ");
            string input3 = Console.ReadLine();
            if (input1 == "" || input2 == "" || input3 == "" || !double.TryParse(input1, out widthOfShape)
                || !double.TryParse(input2, out heightOfShape) || !double.TryParse(input3, out lengthOfShape))
                throw new ArgumentException("Please use only numbers to define the dimensions!");
            if (input1 == input3 || input2 == input3)
                throw new ArgumentException("A box depth cannot be equal to its height or length");
        }

        /// <summary>
        /// ToString method to print all the information of this Shape.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString() + $"[Volume = {Math.Round(CalculateVolume(), 2)}";
        
    }
}
