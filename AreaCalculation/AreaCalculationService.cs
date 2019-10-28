using System;
using AreaCalculation.Interfaces;

namespace AreaCalculation
{
    public class AreaCalculationService : IAreaCalculationService
    {
        public double CalculateArea(IGetAreaShape shape)
        {
            return shape.GetArea();
        }
    }
}
