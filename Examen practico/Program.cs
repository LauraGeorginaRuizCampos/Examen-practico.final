using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    internal class Lista
    {
        // Un campo que indique si la lista es circular o no.
        // Métodos para inserción, eliminación y recorrido(impresión) de elementos.
        // Métodos que consideren si la lista es circular para evitar recorridos infinitos.

        private Nodo primero;
        private Nodo ultimo;
        private string nombre;
        public bool iscircular;


        public Lista(bool iscircular) // nos dice si es circular o no
        {
            primero = null;
            ultimo = null;
            nombre = null;
            this.iscircular = iscircular;
        }

        public Lista(string nombre) // constructor de la lista
        {
            this.nombre = nombre;
            primero = ultimo = null;
            iscircular = false;
        }

        public Lista() // este es el constructor de la lista
        {
            nombre = "Lista";
            primero = ultimo = null;
        }

        public Lista(object dato, string nombre) // aquí menciono que si el primero e sigual al último se crea un nuevo nodo
        {
            this.nombre = nombre;
            primero = ultimo = new Nodo(dato);
        }

        public bool estaVacia() // verifica si la lista esta vacía
        {
            return primero == null;
        }

        public void InsertarUltimo(object elemento) //inserta un elemento al final
        {
            if (estaVacia())
            {
                primero = ultimo = new Nodo(elemento);
            }
            else
            {
                ultimo = ultimo.Siguiente = new Nodo(elemento, null, ultimo);
            }

            checkcircle();
        }

        public void InsertarPrimero(object elemento) //inserta un elemento al principio
        {
            if (estaVacia())
            {
                primero = ultimo = new Nodo(elemento);
            }
            else
            {
                primero = new Nodo(elemento, primero, null);
            }

            checkcircle();
        }

        public object BorrarPrimero() //borra el primer elemento
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = primero.Dato;

            if (primero == ultimo)
            {
                primero = ultimo = null;
            }
            else
            {
                primero = primero.Siguiente;
            }
            checkcircle();
            return ElementoBorrado;
        }

        public object BorrarUltimo() //borra el último elemento
        {
            if (estaVacia())
            {
                throw new ListaVaciaExcepcion(nombre);
            }

            object ElementoBorrado = ultimo.Dato;

            if (primero == ultimo)
            {
                primero = ultimo = null;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != ultimo)
                {
                    actual = actual.Siguiente;
                }

                ultimo = actual;
                actual.Siguiente = null;
            }
            checkcircle();
            return ElementoBorrado;

        }

        public void Imprimirbackwards() //imprime la lista de manera inversa
        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }

            Console.WriteLine("Lista " + nombre);

            Nodo actual = ultimo;

            if (iscircular)
            {
                while (actual != ultimo) //evita loops
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Anterior;
                }
            }
            else
            {
                while (actual != null) // evita loops
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Anterior;
                }
            }
            Console.WriteLine("\n");
        }

        public void Imprimirnormal() //imprime la lista de manera normal

        {
            if (estaVacia())
            {
                Console.WriteLine("La lista " + nombre + " esta vacía.");
                return;
            }

            Console.WriteLine("Lista " + nombre);

            Nodo actual = primero;

            if (iscircular)
            {
                while (actual != primero) //evita loops circulares
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Siguiente;
                }

            }
            else
            {
                while (actual != null) // 
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Siguiente;
                }
            }


            Console.WriteLine("\n");
        }

        private void checkcircle() // pa q sea circular
        {
            if (iscircular && !estaVacia())
            {
                ultimo.Siguiente = primero;
                primero.Anterior = ultimo;

            }
        }





    }
}
