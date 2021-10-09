using System;

namespace TechnicalTaskMindbox.ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            SetSides(firstSide, secondSide, thirdSide);
        }

        public void SetSides(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            if (!Validation())
            {
                throw new Exception("There can be no such triangle");
            }
        }

        private bool Validation()
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

        public double Area()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) *
                             (semiPerimeter - ThirdSide));
        }

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