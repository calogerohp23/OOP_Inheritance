using OOP_Inheritance.Exercise_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Class
{
    public class Profesor : Persona
    {
        public List<Curso>? Curso { get; set; }
        public override string NombreCompleto()
        {
            return $"Profesor.{Nombre} {Apellido}";
        }

        public void AgregarCurso(Curso curso)
        {
            Curso.Add(curso);
        }

    }
}
