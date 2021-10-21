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
 *      Main class of the project Lab2A. 
 *      -Execute the program.
 *      -Display a menu that will let the user create shapes from a variety of options.
 *      -The user will then be prompted to input the dimension of the shape they wish to create.
 *      -The dimension or data required will vary depending on the shape that is to be created.
 *      -Once the user has finished created all the shapes that they wish to create, 
 *       a list of the shapes will be displayed when they decide to close the program.
 * 
 * Notes:
 * 
 *      Processes of this class are shared with the view section called Lab2AView.cs
 *      This class consists mostly of processes that are not reladted to design or view.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Lab2
    { 
        static void Main(string[] args)
        {
            //Instanciate the view class.
            List<Shape> shapes = new List<Shape>();
            Lab2AView view = new Lab2AView(shapes);
            view.ProcessUserSelection();    
        }

        /// <summary>
        /// Create a Shape based on the user selection at the menu and return the newly created shape.
        /// </summary>
        /// <param name="userSelection">User selection from the menu.</param>
        /// <returns>Object of type Shape</returns>
        public static Shape CreateShape(int userSelection)
        {
            try
            {
                switch (userSelection)
                {
                    case 1:
                        Shape rectangle = new Rectangle();
                        rectangle.SetData();
                        return rectangle;
                    case 2:
                        Shape square = new Square();
                        square.SetData();
                        return square;
                    case 3:
                        Shape box = new Box();
                        box.SetData();
                        return box;
                    case 4:
                        Shape cube = new Cube();
                        cube.SetData();
                        return cube;
                    case 5:
                        Shape ellipse = new Ellipse();
                        ellipse.SetData();
                        return ellipse;
                    case 6:
                        Shape circle = new Circle();
                        circle.SetData();
                        return circle;
                    case 7:
                        Shape cylinder = new Cylinder();
                        cylinder.SetData();
                        return cylinder;
                    case 8:
                        Shape sphere = new Sphere();
                        sphere.SetData();
                        return sphere;
                    case 9:
                        Shape triangle = new Triangle();
                        triangle.SetData();
                        return triangle;
                    case 10:
                        Shape tetrahedron = new Tetrahedron();
                        tetrahedron.SetData();
                        return tetrahedron;

                }
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine($"\n - Error! - {e.Message}.\n" +
                    $"Press any key to try again.");
                return null;
            }
            return null;
        }
    }
}
