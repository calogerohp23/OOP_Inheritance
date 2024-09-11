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
        //Constructor de la clase Rectangle
        public Rectangle(double alto, double ancho) : base(alto, ancho) { }

        //Metodo CalculateSurface para la clase Rectangle.
        public override double CalculateSurface()
        {
            return Alto * Ancho;
        }
    }
}
