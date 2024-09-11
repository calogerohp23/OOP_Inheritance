using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_2.Base
{
    abstract class Shape
    {
        //Declaracion de propiedades de la Clase
        public double Alto { get; set; }
        public double Ancho { get; set; }

        //Creacion del constructor de la clase abstractca
        protected Shape(double alto, double ancho)
        {
            Alto = alto;
            Ancho = ancho;
        }

        //Creacion del metodo abstracto
        public abstract double CalculateSurface();
    }
}
