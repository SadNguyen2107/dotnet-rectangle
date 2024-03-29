﻿namespace SN_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height:");
            double height = Double.Parse(Console.ReadLine());
            
            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
        }
    }
}