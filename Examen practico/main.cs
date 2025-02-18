using p;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p
{
    internal class Program
    {

        static bool continuar() // función para permitir cerrar o continuar el programa
        {
            int opcion;
            do
            {
                Console.WriteLine("¿Desea realizar otra operación?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    return true;
                }
                else if (opcion == 2)
                {
                    return false;
                }
            } while (1 == 1);
        }


        static void Main(string[] args) // función princial con la lista y las impresiones
        {
            Lista lista = new Lista("de pacientes pal Simi:\n");

            lista.InsertarUltimo("Valerie");
            lista.InsertarUltimo("Chepe");
            lista.InsertarUltimo("Anton");
            lista.InsertarUltimo("Alex");
            lista.InsertarUltimo("Maikol");
            lista.InsertarUltimo("Yorch UwU");
            /*Console.WriteLine(lista.BorrarPrimero() + " ha sido borrada de la lista.");
            lista.BorrarPrimero();*/
            lista.Imprimirnormal();
            int opcion = 0;

            do //para que se ejecute la función menu siempre y cuando no se elija la op 8
            {
                Menu(opcion, lista);
                if (opcion == 8) { return; }
            } while (continuar() || (opcion < 8 && opcion > 0));


        }

        static void Menu(int opcion, Lista lista) //el menu con las opciones de las operaciones pa que el usuario interactue
        {
            string menuTexto =
                "Bienvenido al menú, ¿qué operación desea realizar?\n" +
                "1. Insertar al principio\n" +
                "2. Insertar al final\n" +
                "3. Borrar al principio\n" +
                "4. Borrar al final\n" +
                "5. Imprimir lista\n" +
                "6. Imprimir lista inversa\n" +
                "7. Checar si es circular o no\n" +
                "8. Salir\n";
            Console.WriteLine(menuTexto);

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion) //dice que se debe ejecutar en cada caso
            {
                case 1:
                    Console.WriteLine("Inserte el elemento a insertar al principio: ");
                    lista.InsertarPrimero(Console.ReadLine());
                    lista.Imprimirnormal();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el elemento a insertar al final: ");
                    lista.InsertarUltimo(Console.ReadLine());
                    lista.Imprimirnormal();
                    break;
                case 3:
                    Console.WriteLine("El elemento " + lista.BorrarPrimero() + "ha sido eliminado");
                    break;
                case 4:
                    Console.WriteLine("El elemento " + lista.BorrarUltimo() + "ha sido eliminado");
                    break;
                case 5:
                    lista.Imprimirnormal();
                    break;
                case 6:
                    lista.Imprimirbackwards();
                    break;
                case 7:
                    if (lista.iscircular) //responde si la lista es circular o no
                    {
                        Console.WriteLine("La lista es circular\n");
                    }
                    else
                    {
                        Console.WriteLine("La lista no es circular\n");
                    }
                    break;
                case 8:
                    Console.WriteLine("Adiós\n");
                    break;
                default:
                    Console.WriteLine("Opción no válida\n");
                    break;
            }


        }
    }
}







