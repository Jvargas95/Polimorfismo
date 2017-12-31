using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Estudiante : ILista_Datos
    {

        public string NombreEstudiante { get; set; }

        public void lista()
        {
            //Console.WriteLine("Estudiantes en la lista");
        }
    }
}
