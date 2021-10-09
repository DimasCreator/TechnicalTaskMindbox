using System;

namespace TechnicalTaskMindbox.ShapeLibrary.Shapes
{
    public class Circle : IShape
    {
        public double Radius
        {
            get => Radius;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Radius cannot be less than zero");
                }
                Radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
        
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}