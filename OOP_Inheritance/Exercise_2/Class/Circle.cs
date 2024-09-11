using OOP_Inheritance.Exercise_2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Class
{
    //Declaracion de la clase Circle, heredando de la clase shape
    class Circle : Shape
    {
        //Declaracion del constructor de la clase Triangle, heredenado los parametros del constructor Shape
        public Circle(double radio) : base(radio, radio) { }

        //Metodo CalculateSurface para la clase Rectangle.
        public override double CalculateSurface()
        {
            return Math.PI * (Ancho * 2);
        }
    }
}
