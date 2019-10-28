using AreaCalculation.Interfaces;
using System;

namespace AreaCalculation.Shapes
{
    public class Triangle : IGetAreaShape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRightTriangle()
        {
            double area = GetArea();

            return area != 0
                ? area == (SideA * SideB) / 2
                || area == (SideB * SideC) / 2
                || area == (SideC * SideA) / 2
                : false;
        }
    }
}
