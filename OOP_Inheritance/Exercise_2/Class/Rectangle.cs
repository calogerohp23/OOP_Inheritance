using OOP_Inheritance.Exercise_2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Class
{
    //Declaracion de la clase Rectangle, la cual herda propiedades y el metodo de la clase abstracta.
    class Rectangle : Shape
    {
        public override double CalculateSurface()
        {
            return Alto * Ancho;
        }
    }
}
