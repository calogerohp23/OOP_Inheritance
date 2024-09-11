using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Class
{
    public class Clase
    {
        public string IdClase { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Curso> Cursos { get; set; }

        public Clase(string idClase)
        {
            IdClase = idClase;
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
            Cursos = new List<Curso>();
        }

        public void AgregarEstudiantes(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesores(Profesor profesor)
        {
            Profesores.Add(profesor);
        }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

    }
}
