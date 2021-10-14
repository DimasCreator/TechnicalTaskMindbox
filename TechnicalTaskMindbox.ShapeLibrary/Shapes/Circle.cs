using System;

namespace TechnicalTaskMindbox.ShapeLibrary.Shapes
{
    /// <summary>
    /// Circle
    /// </summary>
    public class Circle : IShape
    {
        private double _radius;

        /// <summary>
        /// Circle radius
        /// set: If the passed values ​​are less than zero, absolute values ​​are set
        /// </summary>
        public double Radius
        {
            get => _radius;
            set
            {
                _radius = Math.Abs(value);
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