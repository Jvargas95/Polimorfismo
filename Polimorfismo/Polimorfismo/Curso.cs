using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Curso : ILista_Datos
    {
        public string NombreCurso { get; set; }

        public void lista()
        {
            Console.WriteLine();
        }
    }
}
