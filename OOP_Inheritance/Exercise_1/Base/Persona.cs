using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Base
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public abstract string NombreCompleto();
    }
}
