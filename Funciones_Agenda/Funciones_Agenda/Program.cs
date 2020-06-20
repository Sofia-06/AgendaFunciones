using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Agenda
{
    class Program
    {
        static string[,] agenda; // para 10 contactos 
        static int contactos = 0;
        static int contador = 0;
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("Menú de opciones: ");
                Console.WriteLine("1. Crear Contactos ");
                Console.WriteLine("2. Buscar contactos: ");
                Console.WriteLine("3. modificar contacto deseado: ");
                Console.WriteLine("4. Mostrar contactos: ");
                Console.WriteLine("5. Eliminar contacto: ");
                Console.WriteLine("6. Salir: ");
                Console.WriteLine("Ingrese la opción deseada:");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                if (op == 1)
                {
                    contactos = PedirNoContactos();
                    Console.Clear();
                    agenda = new string[10, contactos];
                    Guardarcontacto();
                    Guardarcontacto();
                    MostrarContactos();
                    Console.Clear();
                }
                else if (op == 2)
                {
                    BuscarModificarEliminar('b');
                    MostrarContactos();
                }
                else if (op == 3)
                {
                    BuscarModificarEliminar('m');
                }
                else if (op == 4)
                {
                    BuscarModificarEliminar('e');
                    Guardarcontacto();
                }
                else if (op == 5)
                {
                    Guardarcontacto();
                    MostrarContactos();
                }
                else if (op == 6)
                {
                    Console.WriteLine("desea hacer algo mas: [s/n]  ");
                }

            } while (op == 1);
            Console.ReadKey();
        }
        static int PedirNoContactos()
        {
            Console.Write("Cuantos contactos desea agregar: ");
            return int.Parse(Console.ReadLine());
        }
        static string PedirDatos(string linea)
        {
            string dato = "";
            dato = "Ingrese " + linea + ":";
            return dato;
        }
        static void Guardarcontacto()
        {
            if (contador < contactos)
            {
                Console.Write(PedirDatos("Nombre"));
                agenda[0, contador] = Console.ReadLine();
                Console.Write(PedirDatos("Apellido"));
                agenda[1, contador] = Console.ReadLine();
                Console.Write(PedirDatos("Direccion"));
                agenda[2, contador] = Console.ReadLine();
                Console.Write(PedirDatos("Telefono"));
                agenda[3, contador] = Console.ReadLine();
                contador++;
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Agenda llena\n");
            }
        }
        static void MostrarContactos()
        {
            for (int f = 0; f < contador; f++)
            {
                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");
            }
        }
        static void BuscarModificarEliminar(char tipo)
        {
            string buscar = "";
            Console.Write("Ingrese el Nombre del contacto: ");
            buscar = Console.ReadLine();
            for (int f = 0; f < contactos; f++)
            {
                if (tipo == 'b')
                {
                    if (buscar == agenda[0, f])
                    {
                        Console.Write(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");

                    }
                }
                else if (tipo == 'm')
                {
                    if (buscar == agenda[0, f])
                    {
                        Console.Write(PedirDatos("Nombre: "));
                        agenda[0, f] = Console.ReadLine();
                        Console.Write(PedirDatos("Apellido: "));
                        agenda[1, f] = Console.ReadLine();
                        Console.Write(PedirDatos("Dirección: "));
                        agenda[2, f] = Console.ReadLine();
                        Console.Write(PedirDatos("Teléfono: "));
                        agenda[3, f] = Console.ReadLine();
                    }
                }
                else
                {
                    if (buscar == agenda[0, f])
                    {
                        agenda[0, f] = " ";
                        agenda[1, f] = " ";
                        agenda[2, f] = " ";
                        agenda[3, f] = " ";
                    }
                }

            }
        }
    }
    
}
