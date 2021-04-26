using System;
using System.Globalization;
using System.Collections.Generic;
using Métodos_Abstratos.Entities;
using Métodos_Abstratos.Entities.Enums;

namespace Métodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of the shapes: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double sumShapeCir = 0;
            double sumShapeRet = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter the #{i} shape data:");
                Console.Write("Rectangle or Circle (r/c) = ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Color Black/Blue/Red? = ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width = ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height = ");
                    double height = double.Parse(Console.ReadLine(), CI);
                    string shapeType = "Rectangle";
                    list.Add(new Rectangle(shapeType, color, width, height));
                    Console.WriteLine();

                    double areaRet = width * height;
                    sumShapeRet += areaRet;
                }

                else if (ch == 'c')
                {
                    Console.Write("Color Black/Blue/Red? = ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius = ");
                    double radius = double.Parse(Console.ReadLine());
                    string shapeType = "Circle";
                    list.Add(new Circle(radius, shapeType, color));
                    Console.WriteLine();

                    double areaCir = Math.PI * Math.Pow(radius, 2);
                    sumShapeCir += areaCir;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape's Data");

            foreach (Shape shape in list)
            {
                Console.WriteLine(
                     "Shape Type = "
                    + shape.ShapeType
                    + ", Color = "
                    + shape.Color
                    + ", Area = "
                    + shape.Area().ToString("F2", CI));
            }
            
            Console.WriteLine();
            Console.WriteLine("Rectangle total area = " + sumShapeRet.ToString("F2", CI));
            Console.WriteLine("Circle total area = " + sumShapeCir.ToString("F2", CI));
        }
    }
}
