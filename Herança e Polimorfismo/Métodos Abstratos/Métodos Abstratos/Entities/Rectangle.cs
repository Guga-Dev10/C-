using Métodos_Abstratos.Entities.Enums;

namespace Métodos_Abstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }
        public Rectangle(string shapeType, Color color, double width, double height) : base(shapeType, color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}