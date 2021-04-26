using Métodos_Abstratos.Entities.Enums;

namespace Métodos_Abstratos.Entities
{
    abstract class Shape
    {
        public string ShapeType { get; set; }
        public Color Color { get; set; }
        public object Rectangle { get; internal set; }

        public Shape()
        {
        }
        public Shape(string shapeType, Color color)
        {
            ShapeType = shapeType;
            Color = color;
        }
        public abstract double Area();
    }
}