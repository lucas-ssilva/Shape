﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Entities
{
    abstract class Shape
    {
        public  Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }


        public abstract double Area();

    }
}
