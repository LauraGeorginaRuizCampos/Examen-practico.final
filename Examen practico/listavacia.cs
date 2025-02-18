using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{


    internal class ListaVaciaExcepcion : ApplicationException //esta es la clase de la excepción que muestra lo qye se va a imprimir si la lista llega a estar vacía
    {
        public ListaVaciaExcepcion(string nombre)
            : base("La lista de nombre " + nombre + "esta vacía.")
        {

        }
    }

}
