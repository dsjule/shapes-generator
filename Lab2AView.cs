/*
 * 
 * Author: David Jule. 
 * Date Created: October 6th, 2021.
 * Purpose: Lab Assignment 2 for Programming in .NET Course.
 * 
 * 
 * Description: 
 *          -Display the Menu that will be used by the main program.
 *          -Process the view of the main program.
 *          -Once the user has finished using the program, a list of all the shapes will be displayed.
 *          
 * Notes:
 * 
 *          Processes of this class are shared with the view section called Lab2AView.cs
 *          This class consists mostly of design and formatting.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Lab2AView
    {
        private List<Shape> shapes;
        private Shape newShape;

        public Lab2AView(List<Shape> shapes)
        {
            this.shapes = shapes;
        }


        /// <summary>
        /// Display a string that will show the main menu of the program.
        /// </summary>
        public static void DisplayMenu()
        {
            Console.Write("Please, choose one of the following Options: \n" +
                "1 - Rectangle \n" +
                "2 - Square \n" +
                "3 - Box \n" +
                "4 - Cube \n" +
                "5 - Ellipse \n" +
                "6 - Circle \n" +
                "7 - Cylinder \n" +
                "8 - Sphere \n" +
                "9 - Triangle \n" +
                "10 - Tetrahedron \n" +
                "11 - Exit the Program \n" +
                "\nYour Choice: ");
        }

        /// <summary>
        /// Display the menu and process the selection that the user wishes to select.
        /// This will then prompt for the information needed to create the shape.
        /// Once the information has been successfully processed, a new shape will be created.
        /// Exiting the menu will display all the shapes that were created.
        /// </summary>
        public void ProcessUserSelection()
        {
            DisplayMenu();
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    //Prevent an input that is out of range.
                    if ((int.TryParse(input, out int userSelection) == false) ||
                            userSelection < 1 || userSelection > 11)
                    {
                        Console.Clear();
                        DisplayMenu();
                        throw new ArgumentException("Number selected is out of range. Please Use a value between 1 and 11.");

                    }
                    //Exit the program and display all the shapes that were created.
                    if (userSelection == 11)
                    {
                        Console.Clear();
                        Console.WriteLine("List of shapes that were created : \n" +
                            "Take in mind Areas are represented in squared measurement and Volumes are cubic measurements.\n");
                        DisplayShapes(shapes);
                        Console.WriteLine("\nPress any button to close the program.");
                        Console.Read();
                        break;
                    }

                    //Create and add the new shape to the list of shapes.
                    Console.Clear();
                    newShape = Lab2.CreateShape(userSelection);//Throws argument exception if something goes wrong.
                    if (newShape != null)
                    {
                        shapes.Add(newShape);
                        Console.Write("Shape created successfully. Press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                        DisplayMenu();
                    }
                }catch (ArgumentException e)
                {
                    Console.WriteLine($"\n{e.Message}");
                }
            }  
        }

        /// <summary>
        /// Display all the shapes stored in a list of type Shape calling to the ToString() method.
        /// </summary>
        /// <param name="shapes">List of Type Shape</param>
        public void DisplayShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }

}
