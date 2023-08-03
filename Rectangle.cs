using System;
using System.Collections.Generic;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Hight { get; set; }

        public Rectangle(double width, double hight, Color color)
            : base(color)
        {
            Width = width;
            Hight = hight;
        }

//quando um metodo da superclasse é abstrato, esse metodo
 //precisa estar nas outras subclasses, ao nao ser que a subclasse
//seja abstrata
        public override double Area()
        {
            return Width * Hight;
        }
    }
}
