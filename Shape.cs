using System;
using System.Collections.Generic;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    //shape = figura
    //quando um metodo é abstrato, a classe também deverá ser
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        //quando um metodo é abstrato, nao precisa colocar 'virtual' para que ele seja reescrito na subclasse
        //o termo 'abstract' ja faz isso
        public abstract double Area();
        
    }
}
