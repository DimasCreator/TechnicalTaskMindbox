using System;

namespace TechnicalTaskMindbox.ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        /// <summary>
        /// Constructor 
        /// If passed values ​​less than zero sets the values ​​to zero
        /// </summary>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            SetSides(firstSide, secondSide, thirdSide);
        }

        /// <summary>
        /// Set triangle sides
        /// If passed values ​​less than zero sets the values ​​to zero
        /// </summary>
        public void SetSides(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = ToNonNegative(firstSide);
            SecondSide = ToNonNegative(secondSide);
            ThirdSide = ToNonNegative(thirdSide);
        }

        private double ToNonNegative(double value)
        {
            if (value < 0)
            {
                return 0;
            }
            return value;
        }

        /// <summary>
        /// Checks if a triangle can exist based on its sides
        /// </summary>
        /// <returns>True if possible</returns>
        public bool IsReal()
        {
            if (FirstSide + SecondSide < ThirdSide)
            {
                return false;
            }

            if (FirstSide + ThirdSide < SecondSide)
            {
                return false;
            }

            if (SecondSide + ThirdSide < FirstSide)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Triangle area
        /// </summary>
        /// <returns>Area</returns>
        public double Area()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) *
                             (semiPerimeter - ThirdSide));
        }

        /// <summary>
        /// Is a triangle right-angled
        /// </summary>
        /// <returns>True if right triangle</returns>
        public bool IsRight()
        {
            if (Math.Pow(FirstSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
            {
                return true;
            }
            if (Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2))
            {
                return true;
            }
            if (Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2))
            {
                return true;
            }
            return false;
        }
    }
}