using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Datos<Estudiante> estudiantes = new Lista_Datos<Estudiante>();
            Lista_Datos<Curso> cursos = new Lista_Datos<Curso>();

            for (int i = 1; i <= 5; i++)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.NombreEstudiante = "ESTUDIANTE " + i;
                //estudiante.lista();
                estudiantes.Agregar(estudiante);
            }


            for (int i = 1; i <= 5; i++)
            { 
                Curso curso = new Curso();
                curso.NombreCurso = "CURSO " + i;
                //curso.lista();
                cursos.Agregar(curso);
            }


            foreach (var item in estudiantes.ilista_datos)
            {
                Console.WriteLine(item.NombreEstudiante);
            }

            foreach (var item in cursos.ilista_datos)
            {
                Console.WriteLine(item.NombreCurso);
            }

            Console.ReadKey();
        }
    }
}
