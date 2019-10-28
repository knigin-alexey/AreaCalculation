using AreaCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation.Shapes
{
    public class Circle : IGetAreaShape
    {
        public int Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
