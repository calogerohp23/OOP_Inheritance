using OOP_Inheritance.Exercise_2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Class
{
    class Triangle(double height, double width) : Shape (height, width)
    {
        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
