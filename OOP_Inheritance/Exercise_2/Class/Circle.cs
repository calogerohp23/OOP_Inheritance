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
        public override double CalculateSurface()
        {
            return Math.PI * (Ancho * 2);
        }
    }
}
