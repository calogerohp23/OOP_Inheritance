using OOP_Inheritance.Exercise_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Class
{
    public class Estudiante : Persona
    {
        public override string NombreCompleto()
        {
            return $"{Nombre} + {Apellido}";
        }
    }
}
