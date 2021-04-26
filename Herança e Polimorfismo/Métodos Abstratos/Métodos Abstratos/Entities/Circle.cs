using System;
using Métodos_Abstratos.Entities.Enums;

namespace Métodos_Abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
        }
        public Circle(double radius, string shapeType, Color color) : base(shapeType, color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
