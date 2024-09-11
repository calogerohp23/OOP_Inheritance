using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Base
{
    abstract class Shape(double height, double width)
    {
        public double Height { get; set; } = height;
        public double Width { get; set; } = width;
        public abstract double CalculateSurface();
    }
}
