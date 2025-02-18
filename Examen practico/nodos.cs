using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    internal class Nodo //defino la clase de nodo
    {
        private object dato;
        private Nodo siguiente;
        private Nodo anterior;

        public Nodo(object dato, Nodo siguiente, Nodo anterior) //defino el constructor de cada nodo
        {
            Dato = dato;
            Siguiente = siguiente;
            Anterior = anterior;
        }

        public Nodo(object dato, Nodo siguiente) //defino el constructor con dos parametros
        {
            Dato = dato;
            Siguiente = siguiente;
            Anterior = null;
        }

        public Nodo(object dato) //aqui defino el constructor con un solo parametro
        {
            this.dato = dato;
            this.siguiente = null;
            this.anterior = null;

        }

        public Nodo() //aquí defino el constructor pero sin los parametros
        {
            this.dato = "";
            this.siguiente = null;
            this.anterior = null;
        }

        public object GetDato() //aqui defino el metodo a usar para obtener los datos
        {
            return this.dato;
        }

        public void SetDato(object dato) //aquí defino el metodo para establecer los datos
        {
            this.dato = dato;
        }

        public object Dato //aqui defino las propiedades de los datos
        {
            get { return this.dato; }
            set { this.dato = value; }

        }

        public Nodo Siguiente //aqui defino las propiedades del nodo siguiente
        {
            get { return this.siguiente; }
            set { this.siguiente = value; }
        }

        public Nodo Anterior //aqui defino las propiedades del nodo anterior
        {
            get { return this.anterior; }
            set { this.anterior = value; }

        }
    }
}
