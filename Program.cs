using MetodoAbstrato.Entities;
using System.Collections.Generic;
using System.Globalization;
using MetodoAbstrato.Entities.Enums;


namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red)? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Hight: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Rectangle(width, height, color));
                    //instanciando um retangulo
                }
                else if (ch == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape.Add(new Circle(radius, color));
                }
            }//final for 

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape s in shape)
            {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
