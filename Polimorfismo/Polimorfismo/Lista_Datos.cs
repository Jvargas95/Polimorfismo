using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Lista_Datos<T>
    {
        public static void lista(ILista_Datos ilista_datos)
        {
            ilista_datos.lista();
        }

        public List<T> ilista_datos{ get; set; }

        public Lista_Datos()
        {
            this.ilista_datos = new List<T>();
        }

        public void Agregar(T item)
        {
            ilista_datos.Add(item);
        }
    }
}
