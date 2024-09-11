using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Class
{
    public class Curso
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }
        public Profesor Profesor { get; set; }

        public Curso(string nombre, int recuentoClases, int recuentoEjercicios, Profesor profesor)
        {
            Nombre = nombre;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
            Profesor = profesor;
        }

    }
}
