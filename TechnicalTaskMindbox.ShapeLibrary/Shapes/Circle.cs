using System;

namespace TechnicalTaskMindbox.ShapeLibrary.Shapes
{
    public class Circle : IShape
    {
        private double _radius;
        
        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Circle(double radius)
        {
            Radius = radius;
        }
        
        /// <summary>
        /// Circle area
        /// </summary>
        /// <returns>Area</returns>
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}