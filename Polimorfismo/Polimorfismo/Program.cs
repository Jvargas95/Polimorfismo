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
                ILista_Datos Estudiante = new Estudiante();
                Estudiante estudiante = new Estudiante();
                estudiante.NombreEstudiante = "Estudiante " + i;

                estudiantes.Agregar(estudiante);
            }


            for (int i = 1; i <= 5; i++)
            {
                ILista_Datos Curso = new Curso();
                Curso curso = new Curso();
                curso.NombreCurso = "CURSO " + i;

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
