using System;
using Shapes.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Shape #{0} data:", i);
                Console.Write("Rectangle or Circle (r/c)? ");
                char forma = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                if (forma == 'r' || forma == 'R')
                {
                    Console.Write("Width: ");
                    double alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double lar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(alt, lar, cor));
                }
                else if (forma == 'c' || forma == 'C')
                {
                    Console.Write("Radius: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(raio, cor));
                }

            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape obj in list)
            {
                Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
