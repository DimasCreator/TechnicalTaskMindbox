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
                    throw new Exception("Radius cannot be less than zero");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <exception cref="Exception">If the radius is less than zero, an exception is thrown</exception>
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