using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Cls_Menu
    {
        private static int opcion = 0; // variable para almacenar la opcion del menu

        public static void desplegarMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
                Console.WriteLine(" ");
                Console.WriteLine("***MENU PRINCIPAL***");
                Console.WriteLine(" ");
                Console.WriteLine("1. Agregar Empleados");
                Console.WriteLine("2. Consultar Empleados");
                Console.WriteLine("3. Modificar Empleados");
                Console.WriteLine("4. Borrar Empleados");
                Console.WriteLine("5. Inicializar Arreglos");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Salir");
                Console.WriteLine(" ");
                Console.Write("Ingrese una opcion: ");
                
                int.TryParse(Console.ReadLine(), out opcion); // evalua si el valor ingresado es un numero

                switch (opcion)
                {
                    case 1:// Agregar Empleados

                        break;
                    case 2:// Consultar Empleados

                        break;
                    case 3:// Modificar Empleados
                        
                        break;
                    case 4:// Borrar Empleados

                        break;
                    case 5:// Inicializar Arreglos

                        break;
                    case 6:// Reportes
                        
                        break;
                    case 7:
                        Console.WriteLine("Saliendo... Gracias por usar el Sistema de RH");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Sistema de Recursos Humanos: Modulo de Gestión de Empleados");
                        Console.WriteLine(" ");
                        Console.WriteLine($"La Opcion: '" + opcion + "' no es valida");
                        Console.WriteLine(" ");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 7);
        }
    }
}
