using OOP_Inheritance.Exercise_2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Class
{
    class Circle(double radius) : Shape(radius, radius)
    {
        public override double CalculateSurface()
        {
            return Math.PI * (Width * 2);
        }
    }
}
