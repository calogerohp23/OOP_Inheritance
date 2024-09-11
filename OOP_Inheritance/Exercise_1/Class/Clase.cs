using OOP_Inheritance.Exercise_1.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Class
{
    public class Clase: IAdministrador<Estudiante>, IAdministrador<Profesor>, IAdministrador<Curso>
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


        void IAdministrador<Estudiante>.Agregar(Estudiante elemento)
        {
            Estudiantes.Add(elemento);
        }

        void IAdministrador<Profesor>.Agregar(Profesor profesor)
        {
            Profesores.Add(profesor);
        }
        void IAdministrador<Curso>.Agregar(Curso curso)
        {
            Cursos.Add(curso);
        }
    }
}
