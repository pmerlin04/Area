using System;
using System.Collections.Generic;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) :
            base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
