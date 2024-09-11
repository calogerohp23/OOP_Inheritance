using OOP_Inheritance.Exercise_2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Class
{
    //Declaracion de la clase Triangle, heredando de la clase shape
    class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return Alto * Ancho / 2;
        }
    }
}
